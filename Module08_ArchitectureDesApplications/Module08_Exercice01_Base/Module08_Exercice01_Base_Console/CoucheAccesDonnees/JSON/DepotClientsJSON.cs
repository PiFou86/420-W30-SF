using Module08_Exercice01_Base_Console.CoucheAccesDonnees.JSON.DTO;
using Module08_Exercice01_Base_Console.Entites;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Module08_Exercice01_Base_Console.CoucheAccesDonnees.JSON
{
    public class DepotClientsJSON : IDepotClients
    {
        private string m_nomFichier;
        public DepotClientsJSON(string p_nomFichier)
        {
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
            List<ClientJsonDTO> clients = null;
            if (File.Exists(this.m_nomFichier))
            {
                string json = File.ReadAllText(this.m_nomFichier);
                //JsonSerializerSettings settings = new JsonSerializerSettings
                //{
                //    TypeNameHandling = TypeNameHandling.Auto,
                //    Formatting = Formatting.Indented
                //};
                //clients = JsonConvert.DeserializeObject<List<ClientJsonDTO>>(json, settings);
                clients = JsonSerializer.Deserialize<List<ClientJsonDTO>>(json);
            }
            else
            {
                clients = new List<ClientJsonDTO>();
            }

            return clients;
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
            //JsonSerializerSettings settings = new JsonSerializerSettings
            //{
            //    TypeNameHandling = TypeNameHandling.Auto,
            //    Formatting = Formatting.Indented
            //};
            //string json = JsonConvert.SerializeObject(clientsDTO, settings);
            string json = JsonSerializer.Serialize(
                clientsDTO,
                new JsonSerializerOptions()
                {
                    WriteIndented = true,
                }
            );
            File.WriteAllText(this.m_nomFichier, json);
        }

        public Client RechercherClient(Guid p_clientId)
        {
            return this.ListerClientsDTO()
            .Where(client => client.ClientId == p_clientId)
            .Select(cDTO => cDTO.VersEntite()).SingleOrDefault();
        }
    }
}
