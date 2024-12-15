using System;
using System.Collections.Generic;
using System.Drawing;

namespace POO_Module11_Dessin_Lignes;

public static class DessinRevolution
{
    public static List<PointF> GenererPoints(ConfigurationRevolution p_configurationRevolution)
    {
        if (p_configurationRevolution is null)
        {
            throw new ArgumentNullException(nameof(p_configurationRevolution));
        }

        double conversionDegRad = Math.PI / 180.0;
        PointF dernierPoint = p_configurationRevolution.PositionDepart;
        double angle = 0;
        int longueur = p_configurationRevolution.LongueurDepart;
        List<PointF> pointsLignes = new List<PointF>() { dernierPoint };
        for (int numeroLigne = 0; numeroLigne < p_configurationRevolution.NombreLignes; numeroLigne++)
        {
            PointF point = new PointF()
            {
                X = (float)(dernierPoint.X + Math.Cos(angle * conversionDegRad) * longueur),
                Y = (float)(dernierPoint.Y + Math.Sin(angle * conversionDegRad) * longueur)
            };

            pointsLignes.Add(point);

            angle = (360 + angle + p_configurationRevolution.PasAngle) % 360;
            longueur += p_configurationRevolution.PasLongueur;
            dernierPoint = point;
        }

        return pointsLignes;
    }

    public static List<PointF> SubDiviserKock(List<PointF> p_pointsLignes, int p_nombreIterationKock)
    {
        if (p_pointsLignes is null)
        {
            throw new ArgumentNullException(nameof(p_pointsLignes));
        }
        if (p_pointsLignes.Count < 2)
        {
            throw new ArgumentOutOfRangeException(nameof(p_pointsLignes));
        }
        if (p_nombreIterationKock < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(p_nombreIterationKock));
        }

        List<PointF> pointsLignes = p_pointsLignes;
        for (int nbSubdivision = 0; nbSubdivision < p_nombreIterationKock; nbSubdivision++)
        {
            pointsLignes = SubDiviserKock(pointsLignes);
        }

        return pointsLignes;
    }

    public static List<PointF> Recentrer(List<PointF> pointsLignes, int width, int height)
    {
        PointF barycentre = new PointF();

        foreach (PointF point in pointsLignes)
        {
            barycentre.X += point.X;
            barycentre.Y += point.Y;
        }

        barycentre.X /= pointsLignes.Count;
        barycentre.Y /= pointsLignes.Count;
        PointF translation = new PointF()
        {
            X = (width / 2) - barycentre.X,
            Y = (height / 2) - barycentre.Y,
        };

        List<PointF> points = new List<PointF>();

        foreach (PointF point in pointsLignes)
        {
            points.Add(
                new PointF()
                {
                    X = point.X + translation.X,
                    Y = point.Y + translation.Y
                }
                );
        }

        return points;
    }

    private static List<PointF> SubDiviserKock(List<PointF> p_pointsLignes)
    {
        List<PointF> points = new List<PointF>();
        for (int numeroPoint = 0; numeroPoint < p_pointsLignes.Count - 1; numeroPoint++)
        {
            PointF premierPoint = p_pointsLignes[numeroPoint];
            PointF dernierPoint = p_pointsLignes[numeroPoint + 1];

            points.Add(premierPoint);

            PointF vecteur = new PointF()
            {
                X = (float)((dernierPoint.X - premierPoint.X) / 3.0),
                Y = (float)((dernierPoint.Y - premierPoint.Y) / 3.0)
            };

            PointF a1 = new PointF()
            {
                X = premierPoint.X + vecteur.X,
                Y = premierPoint.Y + vecteur.Y
            };
            points.Add(a1);

            double angleRotation = -Math.PI / 3.0;
            points.Add(
                new PointF()
                {
                    X = a1.X + (float)(vecteur.X * Math.Cos(angleRotation) - vecteur.Y * Math.Sin(angleRotation)),
                    Y = a1.Y + (float)(vecteur.Y * Math.Cos(angleRotation) + vecteur.X * Math.Sin(angleRotation))
                });

            points.Add(
                new PointF()
                {
                    X = premierPoint.X + vecteur.X * 2,
                    Y = premierPoint.Y + vecteur.Y * 2
                });

            points.Add(dernierPoint);
        }

        return points;
    }
}
