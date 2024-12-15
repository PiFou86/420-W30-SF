using System.Drawing;

namespace POO_Module11_Dessin_Lignes;

public class ConfigurationRevolution
{
    public int PasAngle { get; set; }
    public int LongueurDepart { get; set; }
    public int NombreLignes { get; set; }
    public int PasLongueur { get; set; }
    public Point PositionDepart { get; set; }
    public int NombreIterationKock { get; internal set; }
}
