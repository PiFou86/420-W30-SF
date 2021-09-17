using GC.Entites;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace POOII_Module10_GestionClients
{
    public partial class fSaisieClient : Form
    {
        public Client Client { get; set; }
        public bool Nouveau
        {
            get
            {
                return this.Client == null;
            }
        }
        public Client Result { get; private set; }

        public fSaisieClient()
        {
            InitializeComponent();

        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            if (this.Nouveau)
            {
                this.Result = new Client(Guid.NewGuid(), tbNom.Text, tbPrenom.Text, new List<Adresse>());
            }
            else
            {
                this.Result = new Client(this.Client.ClientId, tbNom.Text, tbPrenom.Text, this.Client.Adresses);
            }
        }

        private void fSaisieClient_Load(object sender, EventArgs e)
        {
            this.Text = "Saisie d'un nouveau client";

            if (!this.Nouveau)
            {
                this.Text = "Modification d'un client";
                this.tbNom.Text = this.Client.Nom;
                this.tbPrenom.Text = this.Client.Prenom;
            }
        }
    }
}
