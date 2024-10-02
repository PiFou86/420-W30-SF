using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Module06_Formats_Echanges_PreparationCours.Depots.JSON.DTO
{
    [JsonDerivedType(typeof(CercleJSONDTO), typeDiscriminator: "Cercle")]
    [JsonDerivedType(typeof(PolygoneJSONDTO), typeDiscriminator: "Polygone")]
    public abstract class FormeJSONDTO
    {
        public FormeJSONDTO()
        {
            ;
        }
    }
}
