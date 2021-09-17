using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;

namespace POO_Module11_Dessin_Lignes
{
    public static class DessinRevolution
    {
        public static List<Point> GenererPoints(ConfigurationRevolution p_configurationRevolution)
        {
            if (p_configurationRevolution is null)
            {
                throw new ArgumentNullException(nameof(p_configurationRevolution));
            }

            double conversionDegRad = Math.PI / 180.0;
            Point dernierPoint = p_configurationRevolution.PositionDepart;
            double angle = 0;
            int longueur = p_configurationRevolution.LongueurDepart;
            List<Point> pointsLignes = new List<Point>() { dernierPoint };
            for (int numeroLigne = 0; numeroLigne < p_configurationRevolution.NombreLignes; numeroLigne++)
            {
                Point point = new Point()
                {
                    X = (int)(dernierPoint.X + Math.Cos(angle * conversionDegRad) * longueur),
                    Y = (int)(dernierPoint.Y + Math.Sin(angle * conversionDegRad) * longueur)
                };

                pointsLignes.Add(point);

                angle = (360 + angle + p_configurationRevolution.Angle) % 360;
                longueur += p_configurationRevolution.Pas;
                dernierPoint = point;
            }

            return pointsLignes;
        }
    }
}
