using GC.Entites;
using System;
using System.Windows.Forms;

namespace POOII_Module10_GestionClients
{
    public partial class fPrincipale : Form
    {
        private IDepotClients m_depotClients;

        public fPrincipale(IDepotClients p_depotClients)
        {
            InitializeComponent();

            this.m_depotClients = p_depotClients;

            this.RechercherClients();
        }

        private void tbRecherche_TextChanged(object sender, EventArgs e)
        {
            this.RechercherClients();
        }

        private void RechercherClients()
        {
            lbClient.Items.Clear();
            lbClient.Items.AddRange(m_depotClients.RechercherClients(tbRecherche.Text).ToArray());
        }

        private void bNouveau_Click(object sender, EventArgs e)
        {
            fSaisieClient fSaisieClient = new fSaisieClient();
            DialogResult dr = fSaisieClient.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                this.m_depotClients.AjouterClient(fSaisieClient.Result);
                this.RechercherClients();
            }
        }

        private void lbClient_DoubleClick(object sender, EventArgs e)
        {
            if (lbClient.SelectedItem != null)
            {
                fSaisieClient fSaisieClient = new fSaisieClient();
                fSaisieClient.Client = lbClient.SelectedItem as Client;
                DialogResult dr = fSaisieClient.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    this.m_depotClients.ModifierClient(fSaisieClient.Result);
                    this.RechercherClients();
                }
            }

        }
    }
}
