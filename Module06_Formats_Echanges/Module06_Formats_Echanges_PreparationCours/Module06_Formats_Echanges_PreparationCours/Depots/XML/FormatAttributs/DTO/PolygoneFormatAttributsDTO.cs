using System.Collections.Generic;
using System.Xml.Serialization;

namespace Module06_Formats_Echanges_PreparationCours.Depots.XML.FormatAttributs.DTO;

[XmlType("Polygone")]
public class PolygoneFormatAttributsDTO : FormeFormatAttributsDTO
{
    public List<Point2DFormatAttributsDTO> Sommets { get; set; }
}
