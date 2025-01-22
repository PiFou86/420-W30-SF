using System.Collections.Generic;
using System.Linq;

using Module06_Formats_Echanges_PreparationCours.Entites;

namespace Module06_Formats_Echanges_PreparationCours.Depots.JSON.DTO
{
    public class PolygoneJSONDTO : FormeJSONDTO
    {
        public PolygoneJSONDTO()
        {
            ;
        }

        public PolygoneJSONDTO(Polygone p)
        {
            this.Sommets = p.Sommets.Select(s => new Point2DJSONDTO(s)).ToList();
        }

        public List<Point2DJSONDTO> Sommets { get; set; }

        public override Forme VersEntite()
        {
            return new Polygone(this.Sommets.Select(s => s.VersEntite()));
        }

    }
}
