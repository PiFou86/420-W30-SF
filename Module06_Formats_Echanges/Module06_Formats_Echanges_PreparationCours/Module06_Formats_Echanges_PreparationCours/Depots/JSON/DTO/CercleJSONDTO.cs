using System;
using System.Collections.Generic;
using System.Text;

namespace Module06_Formats_Echanges_PreparationCours.Depots.JSON.DTO;

public class CercleJSONDTO : FormeJSONDTO
{
    public CercleJSONDTO()
    {
        ;
    }
    public Point2DJSONDTO Centre { get; set; }
    public int Rayon { get; set; }
}
