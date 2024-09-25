using System;
using System.Windows.Forms;

namespace Module09_demo;

public partial class fPrincipale : Form
{
    public fPrincipale()
    {
        InitializeComponent();
    }

    private void bAfficher_Click(object sender, EventArgs e)
    {
        DialogResult dr = MessageBox.Show(tbMessage.Text, "Message de l'utilisateur", MessageBoxButtons.YesNo);

    }

    private void tsmiOuvrir_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.Filter = "Fichier Excel (*.xlsx)|*.xlsx|Tous les fichiers (*.*)|*.*";

        DialogResult dr = ofd.ShowDialog();

        if (dr == DialogResult.OK)
        {
            MessageBox.Show($"Le fichier sélectionné est : {ofd.FileName}");
        }
    }

    private void fPrincipale_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult dialogResult = MessageBox.Show("Êtes-vous certain de vouloir quitter ?", "Quitter", MessageBoxButtons.YesNo);

        if (dialogResult == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

    private void tsmiQuitter_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
