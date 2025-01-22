using Module06_Formats_Echanges_PreparationCours.Entites;

namespace Module06_Formats_Echanges_PreparationCours.Depots.JSON.DTO
{
    public class Point2DJSONDTO
    {
        public Point2DJSONDTO()
        {
            ;
        }

        public Point2DJSONDTO(Point2D p)
        {
            this.X = p.X;
            this.Y = p.Y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public Point2D VersEntite()
        {
            return new Point2D() { X = this.X, Y = this.Y };
        }
    }
}
