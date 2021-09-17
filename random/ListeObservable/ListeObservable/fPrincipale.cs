using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fPrincipale : Form
    {
        private ListeObservable<string> m_listeObservable;
        public fPrincipale()
        {
            InitializeComponent();
            this.m_listeObservable = new ListeObservable<string>();


            this.m_listeObservable.Subscribe(new ObserseurListe<string>(
                e =>
                {
                    switch (e.Type)
                    {
                        case TypeListeObservableEvent.AJOUTER:
                            lbElements.Items.Clear();
                            lbElements.Items.AddRange(e.Donnees.ToArray());
                            break;
                        case TypeListeObservableEvent.VIDER:
                            lbElements.Items.Clear();
                            break;
                        default:
                            break;
                    }
                }
                ));


            this.m_listeObservable.Subscribe(new ObserseurListe<string>(
                e =>
                {
                    switch (e.Type)
                    {
                        case TypeListeObservableEvent.AJOUTER:
                            toolStripStatusLabel1.Text = e.Donnees.Count().ToString();
                            break;
                        case TypeListeObservableEvent.VIDER:
                            toolStripStatusLabel1.Text = "0";
                            break;
                        default:
                            break;
                    }
                }));
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            this.m_listeObservable.Add(tbAAjouter.Text);
        }

        private void bVider_Click(object sender, EventArgs e)
        {
            this.m_listeObservable.Clear();
        }
    }
}
