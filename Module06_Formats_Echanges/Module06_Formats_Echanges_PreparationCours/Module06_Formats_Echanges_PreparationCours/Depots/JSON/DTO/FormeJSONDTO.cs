using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

public abstract class FormeJSONDTO
{
    [JsonDerivedType(typeof(CercleJSONDTO), typeDiscriminator: "Cercle")]
    [JsonDerivedType(typeof(PolygoneJSONDTO), typeDiscriminator: "Polygone")]
    public abstract class FormeJSONDTO
    {
        public FormeJSONDTO()
        {
            ;
        }
    }
}
