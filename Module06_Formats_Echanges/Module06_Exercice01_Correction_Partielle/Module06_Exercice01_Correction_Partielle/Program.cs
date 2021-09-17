using Module06_Exercice01_Correction_Partielle.CoucheAccesDonnees.JSON;
using Module06_Exercice01_Correction_Partielle.CoucheAccesDonnees.XML;
using Module06_Exercice01_Correction_Partielle.Entites;
using Module06_Exercice01_Correction_Partielle.TraitementLot;
using System;
using System.IO;
using Unity;

namespace Module06_Exercice01_Correction_Partielle
{
    class Program
    {
        private static string _fichierDepotClientsJSON = "clients.json";
        private static string _fichierDepotClientsXML = "clients.xml";
        static void Main(string[] args)
        {
            GenererFichiersDepotSiNonExistant(false);

            IUnityContainer conteneur = new UnityContainer();

            conteneur.RegisterType<IDepotClients, DepotClientsXML>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { _fichierDepotClientsXML }));
            //conteneur.RegisterType<IDepotClients, DepotClientsJSON>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { _fichierDepotClientsJSON }));

            ClientUIConsole clientUIConsole = conteneur.Resolve<ClientUIConsole>();
            //clientUIConsole.ExecuterUI();

            ITraitementLot tl = null;
            tl = conteneur.Resolve<TraitementLot.ModifierNomPrenomPremiereLettreMajuscules.ModifierNomPrenomPremiereLettreMajusculesTraitementLot>();
            tl.Executer();
            tl = conteneur.Resolve<TraitementLot.ModifierPaysMajusculesClients.ModifierPaysMajusculesClientsTraitementLot>();
           tl.Executer();
        }

        private static void GenererFichiersDepotSiNonExistant(bool p_forceCreation)
        {
            bool fichierDepotClientJSONExiste = File.Exists(_fichierDepotClientsJSON);
            bool fichierDepotClientXMLExiste = File.Exists(_fichierDepotClientsXML);
            
            if (fichierDepotClientJSONExiste && p_forceCreation)
            {
                File.Delete(_fichierDepotClientsJSON);
            }

            if (fichierDepotClientXMLExiste && p_forceCreation)
            {
                File.Delete(_fichierDepotClientsXML);
            }

            if (!fichierDepotClientJSONExiste || p_forceCreation)
            {
                GenerateurDonnees.GenererDepotJsonClients(_fichierDepotClientsJSON);
            }
            if (!fichierDepotClientJSONExiste || p_forceCreation)
            {
                GenerateurDonnees.GenererDepotXMLClients(_fichierDepotClientsXML);
            }
        }
    }
}
