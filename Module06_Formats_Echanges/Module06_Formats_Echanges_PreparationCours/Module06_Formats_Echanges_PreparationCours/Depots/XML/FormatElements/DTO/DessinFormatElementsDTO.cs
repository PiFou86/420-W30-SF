using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Module06_Formats_Echanges_PreparationCours.Depots.XML.FormatElements.DTO
{
    [XmlType("Dessin")]
    public class DessinFormatElementsDTO
    {
        public List<FormeFormatElementsDTO> Formes { get; set; }
    }
}
