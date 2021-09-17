using System;
using System.Collections.Generic;
using System.Text;

namespace Module06_Formats_Echanges_PreparationCours.Entites
{
    public class Cercle : Forme
    {
        private Point2D m_centre;
        public int Rayon { get; }
        public Point2D Centre => new Point2D() { X = this.m_centre.X, Y = this.m_centre.Y };

        public Cercle(Point2D p_centre, int p_rayon)
        {
            this.m_centre = p_centre;
            this.Rayon = p_rayon;
        }

    }
}
