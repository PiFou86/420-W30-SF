using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace POO_Module11_Dessin_Lignes;

public partial class fDessinLignes : Form
{
    public fDessinLignes()
    {
        InitializeComponent();
    }

    public ConfigurationRevolution EtablirConfiguration()
    {
        ConfigurationRevolution cr = new ConfigurationRevolution()
        {
            PasAngle = (int)nudPasAngle.Value,
            LongueurDepart = (int)nudLongueurDepart.Value,
            NombreLignes = (int)nudNombreLignes.Value,
            PasLongueur = (int)nudPasLongueur.Value,
            PositionDepart = new Point(pCanvas.Width / 2, pCanvas.Height / 2),
            NombreIterationKock = (int)nudNombreIterationsFloconsKoch.Value
        };

        return cr;
    }

    private void Dessiner(ConfigurationRevolution p_configurationRevolution, Graphics p_graphics, Pen p_pen)
    {
        if (p_configurationRevolution is null)
        {
            throw new ArgumentNullException(nameof(p_configurationRevolution));
        }

        if (p_graphics is null)
        {
            throw new ArgumentNullException(nameof(p_graphics));
        }

        List<PointF> pointsLignes = DessinRevolution.GenererPoints(p_configurationRevolution);

        p_graphics.DrawLines(p_pen, pointsLignes.ToArray());
    }

    private void DessinerKoch(ConfigurationRevolution p_configurationRevolution, Graphics p_graphics, Pen p_pen)
    {
        if (p_configurationRevolution is null)
        {
            throw new ArgumentNullException(nameof(p_configurationRevolution));
        }

        if (p_graphics is null)
        {
            throw new ArgumentNullException(nameof(p_graphics));
        }

        List<PointF> pointsLignes = DessinRevolution.GenererPoints(p_configurationRevolution);
        pointsLignes = DessinRevolution.SubDiviserKock(pointsLignes, p_configurationRevolution.NombreIterationKock);
        pointsLignes = DessinRevolution.Recentrer(pointsLignes, pCanvas.Width, pCanvas.Height);

        p_graphics.DrawLines(p_pen, pointsLignes.ToArray());
    }

    private void bDessiner_Click(object sender, EventArgs e)
    {
        using (Graphics graphics = pCanvas.CreateGraphics())
        {
            graphics.Clear(Color.White);
            using (Pen pen = new Pen(Color.Black))
            {
                Dessiner(this.EtablirConfiguration(), graphics, pen);
            }
        }
    }

    private void bSubdiviserFloconsKoch_Click(object sender, EventArgs e)
    {
        using (Graphics graphics = pCanvas.CreateGraphics())
        {
            graphics.Clear(Color.White);
            using (Pen pen = new Pen(Color.Black))
            {
                DessinerKoch(this.EtablirConfiguration(), graphics, pen);
            }
        }
    }
}
