using System;
using System.IO;
using System.Windows.Forms;

namespace TestWinform;

public partial class fPrincipale : Form
{
    private string m_titreParDefaut;
    private string m_fichierCourant;
    private bool m_texteModifie;
    private const string filtresFichiers = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";

    public fPrincipale()
    {
        this.InitializeComponent();
        this.m_titreParDefaut = this.Text;
        this.m_texteModifie = false;
        this.MettreAJourApparence();
    }

    private void MettreAJourApparence()
    {
        this.tsmiEnregistrer.Enabled = !string.IsNullOrWhiteSpace(this.m_fichierCourant);
        this.Text = $"{this.m_fichierCourant} - {this.m_titreParDefaut}";
    }

    private void tsmiOuvrir_Click(object sender, EventArgs e)
    {
        if (ConfirmerEnregistrerModificationsSiNessaire("Ouvrir"))
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.Filter = filtresFichiers;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.m_fichierCourant = ofd.FileName;
                this.tbTexte.Text = File.ReadAllText(this.m_fichierCourant);
                this.m_texteModifie = false;
            }

            this.MettreAJourApparence();
        }
    }

    private void tsmiEnregistrer_Click(object sender, EventArgs e)
    {
        this.Enregistrer();
    }

    private void tsmiEnregistrerSous_Click(object sender, EventArgs e)
    {
        this.EnregistrerSous();
    }

    private void Enregistrer()
    {
        if (!string.IsNullOrWhiteSpace(this.m_fichierCourant))
        {
            File.WriteAllText(this.m_fichierCourant, this.tbTexte.Text);
            this.m_texteModifie = false;
        }
    }

    private void EnregistrerSous()
    {
        SaveFileDialog sfd = new SaveFileDialog();
        sfd.Filter = filtresFichiers;

        if (sfd.ShowDialog() == DialogResult.OK)
        {
            this.m_fichierCourant = sfd.FileName;
            this.Enregistrer();
        }
    }

    private void tsmiNouveau_Click(object sender, EventArgs e)
    {
        if (ConfirmerEnregistrerModificationsSiNessaire("Nouveau"))
        {
            this.m_fichierCourant = null;
            this.tbTexte.Text = "";
            this.m_texteModifie = false;

            MettreAJourApparence();
        }
    }

    private void tsmiQuitter_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void tbTexte_TextChanged(object sender, EventArgs e)
    {
        this.m_texteModifie = true;
    }

    private bool ConfirmerEnregistrerModificationsSiNessaire(string p_contexte, FormClosingEventArgs p_e = null)
    {
        bool abandonnerModification = false;
        if (this.m_texteModifie)
        {
            DialogResult dr = MessageBox.Show("Voulez-vous enregistrer les modifications apportées ?",
                                p_contexte,
                                MessageBoxButtons.YesNoCancel);
            switch (dr)
            {
                case DialogResult.Cancel:
                    if (p_e != null) { p_e.Cancel = true; }
                    abandonnerModification = false;
                    break;
                case DialogResult.Yes:
                    if (!string.IsNullOrEmpty(this.m_fichierCourant))
                    {
                        this.Enregistrer();
                    }
                    else
                    {
                        this.EnregistrerSous();
                    }
                    abandonnerModification = true;
                    break;
                case DialogResult.No:
                    abandonnerModification = true;

                    break;
                case DialogResult.None:
                case DialogResult.OK:
                case DialogResult.Abort:
                case DialogResult.Retry:
                case DialogResult.Ignore:
                default:
                    break;
            }
        }
        else
        {
            abandonnerModification = true;
        }

        return abandonnerModification;
    }

    private void fPrincipale_FormClosing(object sender, FormClosingEventArgs e)
    {
        ConfirmerEnregistrerModificationsSiNessaire("Quitter", e);
    }

    private void tsmiCopier_Click(object sender, EventArgs e)
    {
        if (tbTexte.SelectionLength > 0)
        {
            tbTexte.Copy();
        }
    }

    private void tsmiCouper_Click(object sender, EventArgs e)
    {
        if (tbTexte.SelectionLength > 0)
        {
            tbTexte.Cut();
        }
    }

    private void tsmiColler_Click(object sender, EventArgs e)
    {
        if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
        {
            tbTexte.Paste();
        }
    }
}
