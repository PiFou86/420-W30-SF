using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Module06_Formats_Echanges_PreparationCours.Depots.XML.FormatElements.DTO
{
    [XmlType("Point2D")]
    public class Point2DFormatElementsDTO
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
