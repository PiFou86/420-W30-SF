using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOII_Module10_Caisse_Enregistreuse
{
    public partial class fEcranPrincipal : Form
    {
        public Facture Facture { get; }
        public fEcranClient EcranClient { get; }
        public fEcranPrincipal()
        {
            InitializeComponent();
            this.Facture = new Facture();
            this.EcranClient = new fEcranClient(this.Facture);
        }

        private void bSimulerScan_Click(object sender, EventArgs e)
        {
            LigneFacture ligneFacture = new LigneFacture()
            {
                Description = tbSimulationScanDescription.Text,
                PrixUnitaire = nudSimulateurScanPrix.Value,
                Quantite = (int)nudSimulateurScanQuantite.Value
            };

            this.Facture.AjouterLigneFacture(ligneFacture);
        }

        private void fEcranPrincipal_Load(object sender, EventArgs e)
        {
            new ObservateurFacture( this.Facture,
                                    (fe) => {
                                        if (fe.Type == FactureEventType.AJOUT_LIGNE)
                                        {
                                            dgvFacture.Rows.Add(new object[] {
                                                                                fe.LigneFacture.Description,
                                                                                fe.LigneFacture.Quantite,
                                                                                fe.LigneFacture.PrixUnitaire.ToString("c"),
                                                                                fe.LigneFacture.Total.ToString("c")
                                                                             });
                                            tbTotal.Text = fe.Facture.Total.ToString("c");
                                        }
                                    }
            );

            new ObservateurFacture( this.Facture,
                                    (fe) => {
                                        if (fe.Type == FactureEventType.NOUVELLE)
                                        {
                                            dgvFacture.Rows.Clear();
                                            tbTotal.Text = fe.Facture.Total.ToString("c");
                                        }
                                    }
            );

            this.EcranClient.Show();
            this.Facture.Nouvelle();
        }

        private void bPayer_Click(object sender, EventArgs e)
        {
            this.Facture.Nouvelle();
        }
    }
}
