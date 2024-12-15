using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Module08_Exercice01_Base_Console.CoucheAccesDonnees.JSON;
using Module08_Exercice01_Base_Console.CoucheAccesDonnees.XML;
using Module08_Exercice01_Base_Console.Entites;
using Module08_Exercice01_Base_Console.TraitementLot;
using System.IO;
//using Unity;

namespace Module08_Exercice01_Base_Console;

class Program
{
    private static string _fichierDepotClientsJSON = "clients.json";
    private static string _fichierDepotClientsXML = "clients.xml";
    static void Main(string[] args)
    {
        GenererFichiersDepotSiNonExistant(false);

        // Vieille version Unity
        //IUnityContainer conteneur = new UnityContainer();

        //conteneur.RegisterType<IDepotClients, DepotClientsXML>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { _fichierDepotClientsXML }));
        //conteneur.RegisterType<IDepotClients, DepotClientsJSON>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { _fichierDepotClientsJSON }));

        //ClientUIConsole clientUIConsole = conteneur.Resolve<ClientUIConsole>();
        ////clientUIConsole.ExecuterUI();

        //ITraitementLot tl = null;
        //tl = conteneur.Resolve<TraitementLot.ModifierNomPrenomPremiereLettreMajuscules.ModifierNomPrenomPremiereLettreMajusculesTraitementLot>();
        //tl.Executer();
        //tl = conteneur.Resolve<TraitementLot.ModifierPaysMajusculesClients.ModifierPaysMajusculesClientsTraitementLot>();
        //tl.Executer();

        // Nouvelle version avec les outils .Net natifs
        HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
        builder.Services.AddScoped<TraitementLot.ModifierNomPrenomPremiereLettreMajuscules.ModifierNomPrenomPremiereLettreMajusculesTraitementLot>();
        builder.Services.AddScoped<TraitementLot.ModifierPaysMajusculesClients.ModifierPaysMajusculesClientsTraitementLot>();

        builder.Services.AddScoped<IDepotClients, DepotClientsJSON>(serviceProvider => new DepotClientsJSON(_fichierDepotClientsJSON));
        // Ou
        //builder.Services.AddScoped<IDepotClients, DepotClientsXML>(serviceProvider => new DepotClientsXML(_fichierDepotClientsXML));

        IHost host = builder.Build();

        ITraitementLot traitementLot = null;
        using (IServiceScope scope = host.Services.CreateScope())
        {
            traitementLot = scope.ServiceProvider.GetService<TraitementLot.ModifierNomPrenomPremiereLettreMajuscules.ModifierNomPrenomPremiereLettreMajusculesTraitementLot>();
            traitementLot.Executer();
        }

        using (IServiceScope scope = host.Services.CreateScope())
        {
            traitementLot = scope.ServiceProvider.GetService<TraitementLot.ModifierPaysMajusculesClients.ModifierPaysMajusculesClientsTraitementLot>();
            traitementLot.Executer();
        }
    }

    private static void GenererFichiersDepotSiNonExistant(bool p_forceCreation)
    {
        bool fichierDepotClientJSONExiste = File.Exists(_fichierDepotClientsJSON);
        bool fichierDepotClientXMLExiste = File.Exists(_fichierDepotClientsXML);

        if (fichierDepotClientJSONExiste && p_forceCreation)
        {
            File.Delete(_fichierDepotClientsJSON);
        }

        if (fichierDepotClientXMLExiste && p_forceCreation)
        {
            File.Delete(_fichierDepotClientsXML);
        }

        if (!fichierDepotClientJSONExiste || p_forceCreation)
        {
            GenerateurDonnees.GenererDepotJsonClients(_fichierDepotClientsJSON);
        }
        if (!fichierDepotClientJSONExiste || p_forceCreation)
        {
            GenerateurDonnees.GenererDepotXMLClients(_fichierDepotClientsXML);
        }
    }
}
