using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

using Module08_Exercice01_Base_Console.CoucheAccesDonnees.XML.DTO;
using Module08_Exercice01_Base_Console.Entites;

namespace Module08_Exercice01_Base_Console.CoucheAccesDonnees.XML
{
    public class DepotClientsXML : IDepotClients
    {
        private string m_nomFichier;
        public DepotClientsXML(string p_nomFichier)
        {
            if (string.IsNullOrEmpty(p_nomFichier))
            {
                throw new ArgumentException("Le nom de fichier est null ou vide.", nameof(p_nomFichier));
            }

            this.m_nomFichier = p_nomFichier;
        }

        public void AjouterClient(Client p_client)
        {
            if (p_client is null)
            {
                throw new ArgumentNullException(nameof(p_client));
            }

            List<ClientXMLDTO> clientsDTO = this.ListerClientsDTO();
            if (clientsDTO.Any(c => c.ClientId == p_client.ClientId))
            {
                throw new InvalidOperationException();
            }

            ClientXMLDTO clientDTO = new ClientXMLDTO(p_client);
            clientsDTO.Add(clientDTO);

            this.SauvegarderDepot(clientsDTO);
        }

        public List<Client> ListerClients()
        {
            List<ClientXMLDTO> clientsDTO = this.ListerClientsDTO();

            return clientsDTO.Select(cDTO => cDTO.VersEntite()).ToList();
        }

        private List<ClientXMLDTO> ListerClientsDTO()
        {
            List<ClientXMLDTO>? clients = null;
            if (File.Exists(this.m_nomFichier))
            {
                try
                {
                    XmlReader document = XmlReader.Create(this.m_nomFichier);
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<ClientXMLDTO>));
                    clients = xmlSerializer.Deserialize(document) as List<ClientXMLDTO> ?? new List<ClientXMLDTO>();
                    document.Close();
                }
                catch (Exception)
                {
                    ; // Pas la bonne façon ici mais suffisante pour le contexte de l'exercice.
                }
            }

            return clients ?? new List<ClientXMLDTO>();
        }

        public void ModifierClient(Client p_client)
        {
            if (p_client is null)
            {
                throw new ArgumentNullException(nameof(p_client));
            }
            List<ClientXMLDTO> clientsDTO = this.ListerClientsDTO();
            if (clientsDTO.RemoveAll(cDTO => cDTO.ClientId == p_client.ClientId) != 1)
            {
                throw new InvalidOperationException();
            }
            clientsDTO.Add(new ClientXMLDTO(p_client));
            this.SauvegarderDepot(clientsDTO);
        }

        private void SauvegarderDepot(List<ClientXMLDTO> clientsDTO)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "  ";

            using (XmlWriter doc = XmlWriter.Create(this.m_nomFichier, settings))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<ClientXMLDTO>));
                doc.WriteStartDocument();
                xmlSerializer.Serialize(doc, clientsDTO);
                doc.Close();
            }
        }

        public Client? ObtenirClient(Guid p_clientId)
        {
            return this.ListerClientsDTO()
                .Where(client => client.ClientId == p_clientId)
                .Select(cDTO => cDTO.VersEntite()).SingleOrDefault();
        }
    }
}
