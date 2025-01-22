using Module06_Formats_Echanges_PreparationCours.Entites;

namespace Module06_Formats_Echanges_PreparationCours.Depots.JSON.DTO
{
    public class CercleJSONDTO : FormeJSONDTO
    {
        public CercleJSONDTO()
        {
            ;
        }

        public CercleJSONDTO(Cercle c)
        {
            this.Centre = new Point2DJSONDTO(c.Centre);
            this.Rayon = c.Rayon;
        }

        public Point2DJSONDTO Centre { get; set; }
        public int Rayon { get; set; }

        public override Forme VersEntite()
        {
            return new Cercle(this.Centre.VersEntite(), this.Rayon);
        }
    }
}
