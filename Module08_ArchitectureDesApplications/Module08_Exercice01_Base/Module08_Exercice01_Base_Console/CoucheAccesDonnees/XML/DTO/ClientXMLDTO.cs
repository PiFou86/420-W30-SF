using Module08_Exercice01_Base_Console.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Module08_Exercice01_Base_Console.CoucheAccesDonnees.XML.DTO
{
    [XmlType("Client")]
    public class ClientXMLDTO
    {
        public ClientXMLDTO() { }

        public ClientXMLDTO(Client p_client)
        {
            this.ClientId = p_client.ClientId;
            this.Nom = p_client.Nom;
            this.Prenom = p_client.Prenom;
            this.Adresses = p_client.Adresses?.Select(a => new AdresseXMLDTO(a)).ToList();
        }

        public Guid ClientId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public List<AdresseXMLDTO> Adresses { get; set; }

        public Client VersEntite()
        {
            List<Adresse> adresses = this.Adresses.Select(aDTO => aDTO.VersEntite()).ToList();

            return new Client(this.ClientId, this.Nom, this.Prenom, adresses);
        }
    }
}