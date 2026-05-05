using System;
using System.Collections.Generic;
using System.Linq;

using Module08_Exercice01_Base_Console.Entites;

namespace Module08_Exercice01_Base_Console.CoucheAccesDonnees.JSON.DTO
{
    public class ClientJsonDTO
    {
        public Guid ClientId { get; set; } = Guid.Empty;
        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public List<AdresseJsonDTO> Adresses { get; set; } = new List<AdresseJsonDTO>();

        public ClientJsonDTO() { }

        public ClientJsonDTO(Client p_client)
        {
            if (p_client is null)
            {
                throw new ArgumentNullException(nameof(p_client), "Le client ne peut pas être null.");
            }

            this.ClientId = p_client.ClientId;
            this.Nom = p_client.Nom;
            this.Prenom = p_client.Prenom;
            this.Adresses = p_client.Adresses?.Select(a => new AdresseJsonDTO(a)).ToList() ?? new List<AdresseJsonDTO>();
        }

        public Client VersEntite()
        {
            List<Adresse> adresses = this.Adresses?.Select(aDTO => aDTO.VersEntite()).ToList() ?? new List<Adresse>();

            return new Client(this.ClientId, this.Nom, this.Prenom, adresses);
        }
    }
}
