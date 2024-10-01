using System.Collections.Generic;

namespace Module06_Formats_Echanges_PreparationCours.Depots.JSON.DTO
{
    public class PolygoneJSONDTO : FormeJSONDTO
    {
        public PolygoneJSONDTO()
        {
            ;
        }
        public List<Point2DJSONDTO> Sommets { get; set; }
    }
}
