using GC.Entites;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GC.ConsoleUI
{
    // Code adapté du code de Paul Vachon
    public class ClientUIConsole
    {
        private IDepotClients m_depotClient;

        public ClientUIConsole(IDepotClients p_depotClient)
        {
            this.m_depotClient = p_depotClient;
        }

        public void ExecuterUI()
        {
            bool programmeEnExecution = true;

            while (programmeEnExecution)
            {
                AfficherMenu();
                int choixMenu = SaisirChoixMenu();

                switch (choixMenu)
                {
                    case 1:
                        this.m_depotClient.AjouterClient(SaisirClientAvecAdresse());
                        break;
                    case 2:
                        RechercherEtAfficherClientParGuid();
                        break;
                    case 3:
                        ListerEtAfficherLesClients();
                        break;
                    case 0:
                        programmeEnExecution = false;
                        break;
                    default:
                        break;
                }
            }
        }
        public void AfficherMenu()
        {
            Console.Out.WriteLine("MENU PRINCIPAL");
            Console.Out.WriteLine("[1] Ajouter un nouveau client avec ses adresses(aléatoires)");
            Console.Out.WriteLine("[2] Rechercher un client par son Guid");
            Console.Out.WriteLine("[3] Lister et afficher tous les clients");
            Console.Out.WriteLine("[0] Quitter");
        }
        public int SaisirChoixMenu()
        {
            int choix = -1;
            while (choix < 0 || choix > 3)
            {
                Console.Out.WriteLine("Entrez votre choix, de 0 a 3:");
                choix = Convert.ToInt32(Console.In.ReadLine());
            }
            return choix;
        }
        public Client SaisirClientAvecAdresse()
        {
            string nom = null;
            string prenom = null;
            int nombreAdresses = 0;
            do
            {
                Console.Out.WriteLine("Prenom :");
                prenom = Console.In.ReadLine();
                if (string.IsNullOrWhiteSpace(prenom))
                {
                    Console.Out.WriteLine("Le prénom ne doit pas être vide !");
                }
            } while (string.IsNullOrWhiteSpace(prenom));

            do
            {
                Console.Out.WriteLine("Nom :");
                nom = Console.In.ReadLine();
                if (string.IsNullOrWhiteSpace(nom))
                {
                    Console.Out.WriteLine("Le nom ne doit pas être vide !");
                }
            } while (string.IsNullOrWhiteSpace(nom));

            do
            {
                Console.Out.WriteLine("Combien d'adresse voulez vous générer?");
                nombreAdresses = Convert.ToInt32(Console.In.ReadLine());
                if (nombreAdresses < 1)
                {
                    Console.Out.WriteLine("Le nombre d'addresses doit être suppérieur à 0");
                }
            } while (nombreAdresses < 1);

            List<Adresse> listeAdresses = Enumerable.Range(1, nombreAdresses).Select(_ => GenerateurDonnees.GenererAdresseAleatoire()).ToList();
            Client clientSaisi = new Client(Guid.NewGuid(), nom, prenom, listeAdresses);

            return clientSaisi;
        }

        public void RechercherEtAfficherClientParGuid()
        {
            Console.Out.WriteLine("Entrez le Guid du client pour commencer la recherche :");
            Guid guidClient = Guid.Parse(Console.In.ReadLine());
            AfficherClient(this.m_depotClient.RechercherClient(guidClient));
        }
        public void AfficherClient(Client p_client)
        {
            Console.Out.WriteLine("Client :");
            Console.Out.WriteLine($"\tId : {p_client.ClientId}");
            Console.Out.WriteLine($"\tPrénom : {p_client.Prenom}");
            Console.Out.WriteLine($"\tNom : {p_client.Nom}");
            Console.Out.WriteLine($"\tAdresses ({p_client.Adresses.Count}) :");
            foreach (Adresse adresse in p_client.Adresses)
            {
                Console.Out.WriteLine("\t*");
                Console.Out.WriteLine($"\t\tId : {adresse.AdresseId}");
                Console.Out.WriteLine($"\t\tNuméro civique : {adresse.NumeroCivique}");
                Console.Out.WriteLine($"\t\tType voie : {adresse.TypeVoie}");
                Console.Out.WriteLine($"\t\tOdonyme : {adresse.Odonyme}");
                Console.Out.WriteLine($"\t\tInformation supplémentaire : {adresse.InformationSupplementaire}");
                Console.Out.WriteLine($"\t\tMunicipalité : {adresse.NomMunicipalite}");
                Console.Out.WriteLine($"\t\tCode postal : {adresse.CodePostal}");
                Console.Out.WriteLine($"\t\tEtat : {adresse.Etat}");
                Console.Out.WriteLine($"\t\tPays : {adresse.Pays}");
                Console.Out.WriteLine();
            }
        }
        public void ListerEtAfficherLesClients()
        {
            List<Client> listeDesClients = this.m_depotClient.ListerClients();
            listeDesClients.ForEach(client => AfficherClient(client));
        }

    }
}
