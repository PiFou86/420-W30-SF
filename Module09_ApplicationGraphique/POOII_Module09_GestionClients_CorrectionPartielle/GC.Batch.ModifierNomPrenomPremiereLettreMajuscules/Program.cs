using GC.DAL.JSON;
using GC.DAL.XML;
using GC.Entites;
// sujet
using Microsoft.Extensions.Configuration;

using System;
using System.IO;
using Unity;

namespace GC.Batch.ModifierNomPrenomPremiereLettreMajuscules
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sujet : installer packages
            // Microsoft.Extensions.Configuration
            // Microsoft.Extensions.Configuration.FileExtensions
            // Microsoft.Extensions.Configuration.Json
            // Unity
            // Créer le fichier "appsettings.json"
            // Ajoutez le contenu : 
            // où ...
            // Modifiez le propriété du fichier pour qu'il soit copié au moment de la compilation
            // Copier dans le répertoire de sortie, sélectionnez "Copier si plus récent"

            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
            .AddJsonFile("appsettings.json", false)
            .Build();

            string repertoireDepotClient = configuration["RepertoireDepotsClients"];
            string nomFichierDepotClient = configuration["NomFichierDepotClients"];
            string cheminComplet = Path.Combine(repertoireDepotClient, nomFichierDepotClient);

            if (!File.Exists(cheminComplet))
            {
                throw new InvalidOperationException($"Le fichier {cheminComplet} n'existe pas ou est inaccessible");
            }

            string typeDepot = configuration["TypeDepot"];

            IUnityContainer conteneur = new UnityContainer();
            conteneur.RegisterInstance(configuration, InstanceLifetime.Singleton);

            switch (typeDepot.ToLower())
            {
                case "json":
                    conteneur.RegisterType<IDepotClients, DepotClientsJSON>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { cheminComplet }));
                    break;
                case "xml":
                    conteneur.RegisterType<IDepotClients, DepotClientsXML>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { cheminComplet }));
                    break;
                default:
                    throw new InvalidOperationException("le type de dépot n'est pas valide, mettre json ou xml");
            }


            ITraitementLot tl = null;
            tl = conteneur.Resolve<ModifierNomPrenomPremiereLettreMajusculesTraitementLot>();
            tl.Executer();
        }
    }
}