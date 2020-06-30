using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Module06_Formats_Echanges_PreparationCours.Depots.XML.FormatElements.DTO
{
    [XmlType("Polygone")]
    public class PolygoneFormatElementsDTO : FormeFormatElementsDTO
    {
        public List<Point2DFormatElementsDTO> Sommets { get; set; }
    }
}
