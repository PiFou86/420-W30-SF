using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POOII_Module10_Caisse_Enregistreuse
{
    public partial class fEcranClient : Form
    {
        public Facture Facture { get; }
        public fEcranClient(Facture p_facture)
        {
            InitializeComponent();
            this.Facture = p_facture;
        }

        private void fEcranClient_Load(object sender, EventArgs e)
        {
            new ObservateurFacture(
                this.Facture,
                (fe) =>
                {
                    if (fe.Type == FactureEventType.AJOUT_LIGNE) {
                            tbAffichage.Text = $"{fe.LigneFacture.Description.Substring(0, Math.Min(10, fe.LigneFacture.Description.Length)).PadRight(10)}{fe.LigneFacture.Quantite.ToString().PadLeft(5)} @ {fe.LigneFacture.PrixUnitaire.ToString("c")}";
                    }
                }
            );
            new ObservateurFacture(
                this.Facture,
                (fe) =>
                {
                    if (fe.Type == FactureEventType.NOUVELLE) { 
                            tbAffichage.Text = "Bienvenue";
                    }
                }
           );
        }
    }
}
