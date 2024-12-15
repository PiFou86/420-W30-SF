using System;
using System.Drawing;
using System.Windows.Forms;

namespace POOII_Module10_Observeur_Demo;

public partial class fPrincipale : Form
{
    private ChaineObservable _donneeAObserver;
    public fPrincipale()
    {
        InitializeComponent();
        _donneeAObserver = new ChaineObservable();
    }

    private void fPrincipale_Load(object sender, EventArgs e)
    {
        new ChaineObservateurGenerique(_donneeAObserver,
        (valeur) => { lEcho.Text = valeur; }
        );

        new ChaineObservateurGenerique(_donneeAObserver,
        (valeur) => { lCouleur.BackColor = (valeur == "Ok") ? Color.Green : Color.Red; }
        );
    }

    private void tbTexte_TextChanged(object sender, EventArgs e)
    {
        this._donneeAObserver.Valeur = tbTexte.Text;
    }
}
