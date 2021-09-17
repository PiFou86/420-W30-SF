using GC.DAL.JSON;
using GC.DAL.XML;
using GC.Entites;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Unity;

namespace GC.Batch.ModifierPaysMajusculesClients
{
    class Program
    {
        static void Main(string[] args)
        {
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
            tl = conteneur.Resolve<ModifierPaysMajusculesClientsTraitementLot>();
            tl.Executer();
        }
    }
    }
