using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using System.IO;

using Module08_Exercice01_Base_Console.CoucheAccesDonnees.JSON.DTO;
using Module08_Exercice01_Base_Console.Entites;


namespace Module08_Exercice01_Base_Console.CoucheAccesDonnees.JSON
{
    public class DepotClientsJSON : IDepotClients
    {
        private string m_nomFichier;
        public DepotClientsJSON(string p_nomFichier)
        {
            if (string.IsNullOrWhiteSpace(p_nomFichier))
            {
                throw new ArgumentException("Le nom du fichier ne peut pas être null ou vide.", nameof(p_nomFichier));
            }

            this.m_nomFichier = p_nomFichier;
        }

        public void AjouterClient(Client p_client)
        {
            if (p_client is null)
            {
                throw new ArgumentNullException(nameof(p_client));
            }

            List<ClientJsonDTO> clientsDTO = this.ListerClientsDTO();
            if (clientsDTO.Any(c => c.ClientId == p_client.ClientId))
            {
                throw new InvalidOperationException();
            }

            ClientJsonDTO clientDTO = new ClientJsonDTO(p_client);
            clientsDTO.Add(clientDTO);

            this.SauvegarderDepot(clientsDTO);
        }

        public List<Client> ListerClients()
        {
            List<ClientJsonDTO> clientsDTO = this.ListerClientsDTO();

            return clientsDTO.Select(cDTO => cDTO.VersEntite()).ToList();
        }

        private List<ClientJsonDTO> ListerClientsDTO()
        {
            List<ClientJsonDTO>? clients = null;
            if (File.Exists(this.m_nomFichier))
            {
                string json = File.ReadAllText(this.m_nomFichier);

                try
                {
                    clients = JsonSerializer.Deserialize<List<ClientJsonDTO>>(json);
                }
                catch (Exception)
                {
                    ; // Pas la bonne façon ici mais suffisante pour le contexte de l'exercice.
                }
            }

            return clients ?? new List<ClientJsonDTO>();
        }

        public void ModifierClient(Client p_client)
        {
            if (p_client is null)
            {
                throw new ArgumentNullException(nameof(p_client));
            }
            List<ClientJsonDTO> clientsDTO = this.ListerClientsDTO();
            if (clientsDTO.RemoveAll(cDTO => cDTO.ClientId == p_client.ClientId) != 1)
            {
                throw new InvalidOperationException();
            }
            clientsDTO.Add(new ClientJsonDTO(p_client));
            this.SauvegarderDepot(clientsDTO);
        }

        private void SauvegarderDepot(List<ClientJsonDTO> clientsDTO)
        {
            string json = JsonSerializer.Serialize(
                clientsDTO,
                new JsonSerializerOptions()
                {
                    WriteIndented = true,
                }
            );
            File.WriteAllText(this.m_nomFichier, json);
        }

        public Client? ObtenirClient(Guid p_clientId)
        {
            return this.ListerClientsDTO()
            .Where(client => client.ClientId == p_clientId)
            .Select(cDTO => cDTO.VersEntite()).SingleOrDefault();
        }
    }
}
