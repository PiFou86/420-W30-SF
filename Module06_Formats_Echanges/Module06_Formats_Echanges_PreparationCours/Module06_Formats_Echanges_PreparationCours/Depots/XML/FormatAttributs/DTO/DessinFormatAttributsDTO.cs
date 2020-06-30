using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Module06_Formats_Echanges_PreparationCours.Depots.XML.FormatAttributs.DTO
{
    [XmlRoot(ElementName = "Dessin")]
    public class DessinFormatAttributsDTO
    {
        public List<FormeFormatAttributsDTO> Formes { get; set; }
    }
}
