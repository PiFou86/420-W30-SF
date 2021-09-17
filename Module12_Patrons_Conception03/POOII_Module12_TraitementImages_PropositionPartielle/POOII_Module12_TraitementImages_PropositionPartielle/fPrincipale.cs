using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOII_Module11_Paint
{
    public partial class fPrincipale : Form
    {
        private ImageManipulable m_imageManipulable;

        public fPrincipale()
        {
            InitializeComponent();
        }

        private void pCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            sslPositionSouris.Text = $"{e.X}, {e.Y}";
        }

        private void tsmiOuvrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.m_imageManipulable = new ImageManipulable(ofd.FileName);
                pbImage.Image = this.m_imageManipulable.Image;
            }
        }

        private void fPrincipale_Load(object sender, EventArgs e)
        {
            cbTraitementAAjouter.Items.AddRange(UtilitaireTraitements.RechercherTraitementsImage().ToArray());
        }

        private void bAjouterTraitement_Click(object sender, EventArgs e)
        {
            object traitementSelectionne = cbTraitementAAjouter.SelectedItem;
            if (traitementSelectionne != null)
            {
                lbSuiteTraitementsAAppliquer.Items.Add(((CreateurTraitement)traitementSelectionne).Creer());
            }
        }

        private void lbSuiteTraitementsAAppliquer_SelectedIndexChanged(object sender, EventArgs e)
        {
            pgProprieteTraitementSelectionne.SelectedObject = lbSuiteTraitementsAAppliquer.SelectedItem;
        }

        private void bSupprimerTraitement_Click(object sender, EventArgs e)
        {
            lbSuiteTraitementsAAppliquer.Items.Remove(lbSuiteTraitementsAAppliquer.SelectedItem);
        }

        private void bSuiteTraitementsDeplacerHaut_Click(object sender, EventArgs e)
        {
            DeplacerElementListBox(lbSuiteTraitementsAAppliquer, -1);
        }

        private void bSuiteTraitementsDeplacerBas_Click(object sender, EventArgs e)
        {
            DeplacerElementListBox(lbSuiteTraitementsAAppliquer, 1);
        }

        private void DeplacerElementListBox(ListBox p_listBox, int p_pas)
        {
            int index = p_listBox.SelectedIndex;
            if (index >= 0)
            {
                object traitementSelectionne = p_listBox.SelectedItem;
                p_listBox.Items.Remove(traitementSelectionne);
                p_listBox.Items.Insert(Math.Max(0, Math.Min(index + p_pas, p_listBox.Items.Count)), traitementSelectionne);
                p_listBox.SelectedItem = traitementSelectionne;
            }
        }

        private void bAppliquerSuiteTraitements_Click(object sender, EventArgs e)
        {
            if (this.m_imageManipulable != null && lbSuiteTraitementsAAppliquer.Items.Count > 0)
            {
                List<ITraitementImage> traitements = new List<ITraitementImage>();
                foreach (object traitement in lbSuiteTraitementsAAppliquer.Items)
                {
                    traitements.Add((ITraitementImage)((ITraitementImage)traitement).Clone());
                }

                for (int numeroTraitement = 0; numeroTraitement < traitements.Count - 1; numeroTraitement++)
                {
                    traitements[numeroTraitement].Suivant = traitements[numeroTraitement + 1];
                }

                traitements[0].TraiterImage(this.m_imageManipulable);
                pbImage.Image = this.m_imageManipulable.Image;
            }
        }
    }
}
