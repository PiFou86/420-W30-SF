using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Module06_Formats_Echanges_PreparationCours.Depots.XML.FormatAttributs.DTO
{
    [XmlType("Cercle")]
    public class CercleFormatAttributsDTO : FormeFormatAttributsDTO
    {
        public Point2DFormatAttributsDTO Centre { get; set; }
        [XmlAttribute()]
        public int Rayon { get; set; }
    }
}
