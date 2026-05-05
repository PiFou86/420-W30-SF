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
        public Guid ClientId { get; set; } = Guid.Empty;
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public List<AdresseXMLDTO> Adresses { get; set; } = new List<AdresseXMLDTO>();

        public ClientXMLDTO() { }

        public ClientXMLDTO(Client? p_client)
        {
            if (p_client is null)
            {
                throw new ArgumentNullException(nameof(p_client), "Le client ne peut pas être null.");
            }

            this.ClientId = p_client.ClientId;
            this.Nom = p_client.Nom;
            this.Prenom = p_client.Prenom;
            this.Adresses = p_client.Adresses?.Select(a => new AdresseXMLDTO(a)).ToList() ?? new List<AdresseXMLDTO>();
        }

        public Client VersEntite()
        {
            List<Adresse> adresses = this.Adresses?.Select(aDTO => aDTO.VersEntite()).ToList() ?? new List<Adresse>();

            return new Client(this.ClientId, this.Nom, this.Prenom, adresses);
        }
    }
}
