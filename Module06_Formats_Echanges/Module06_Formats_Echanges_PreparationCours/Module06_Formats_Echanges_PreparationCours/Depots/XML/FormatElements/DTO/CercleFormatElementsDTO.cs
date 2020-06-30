using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Module06_Formats_Echanges_PreparationCours.Depots.XML.FormatElements.DTO
{
    [XmlType("Cercle")]
    public class CercleFormatElementsDTO : FormeFormatElementsDTO
    {
        public Point2DFormatElementsDTO Centre { get; set; }
        public int Rayon { get; set; }
    }
}
