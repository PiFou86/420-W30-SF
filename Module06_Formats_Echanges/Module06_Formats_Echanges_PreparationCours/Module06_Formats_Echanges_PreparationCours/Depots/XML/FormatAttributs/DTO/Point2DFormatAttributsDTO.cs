using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Module06_Formats_Echanges_PreparationCours.Depots.XML.FormatAttributs.DTO
{
    [XmlType("Point2D")]
    public class Point2DFormatAttributsDTO
    {
        [XmlAttribute()]
        public int X { get; set; }
        [XmlAttribute()]
        public int Y { get; set; }
    }
}
