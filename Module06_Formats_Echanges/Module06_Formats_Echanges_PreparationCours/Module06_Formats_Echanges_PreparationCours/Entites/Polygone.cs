using System.Collections.Generic;

namespace Module06_Formats_Echanges_PreparationCours.Entites;

public class Polygone : Forme
{
    private List<Point2D> m_sommets;
    public List<Point2D> Sommets
    {
        get
        {
            return new List<Point2D>(this.m_sommets);
        }
    }

    public Polygone(IEnumerable<Point2D> p_sommets)
    {
        this.m_sommets = new List<Point2D>(p_sommets);
    }
}
