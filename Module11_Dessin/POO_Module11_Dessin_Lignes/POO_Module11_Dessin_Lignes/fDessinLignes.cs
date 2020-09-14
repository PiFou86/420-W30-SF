using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Module11_Dessin_Lignes
{
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
                Angle = (int)nudAngle.Value,
                LongueurDepart = (int)nudLongueurDepart.Value,
                NombreLignes = (int)nudNombreLignes.Value,
                Pas = (int)nudPas.Value,
                PositionDepart = new Point(pCanvas.Width / 2, pCanvas.Height / 2)
            };

            return cr;
        }

        public void Dessiner(ConfigurationRevolution p_configurationRevolution, Graphics p_graphics, Pen p_pen)
        {
            if (p_configurationRevolution is null)
            {
                throw new ArgumentNullException(nameof(p_configurationRevolution));
            }

            if (p_graphics is null)
            {
                throw new ArgumentNullException(nameof(p_graphics));
            }

            List<Point> pointsLignes = DessinRevolution.GenererPoints(p_configurationRevolution);

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
    }
}
