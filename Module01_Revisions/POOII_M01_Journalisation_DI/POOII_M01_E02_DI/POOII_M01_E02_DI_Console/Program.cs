using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using POOII_M01_E02_DI_Interfaces;
using POOII_M01_E02_DI_Journaux;
using System.Security.AccessControl;

namespace POOII_M01_E02_DI_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création d'un hôte d'application
            // Il va lire les paramètres de configuration et les
            // injecter dans les services. Pour la configuration, il va lire
            // les paramètres de la ligne de commande, le fichier appsettings.jsons si existant
            // et les variables d'environnement
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

            // Récupération du type de journalisation. Il est defini dans le fichier appsettings.json
            // Il est possible d'écraser cette valeur grâce aux paramètres de la ligne de commande
            // ou les variables d'environnement : dotnet run --journal ConsoleJournalAvecHeure
            // ou set journal=ConsoleJournalAvecHeure
            string? typeJournalisation = builder.Configuration["journal"];
            // Selon le type de journalisation, on va enregistrer le service correspondant
            switch (typeJournalisation)
            {
                case "ConsoleJournal":
                    builder.Services.AddScoped<IJournal, ConsoleJournal>();
                    break;
                case "ConsoleJournalAvecHeure":
                    builder.Services.AddScoped<IJournal, ConsoleJournalAvecHeure>();
                    break;
                case "FichierJournal":
                    builder.Services.AddScoped<IJournal, FichierJournal>();
                    break;
                default:
                    throw new ArgumentException("Langue non supportée");
            }

            // Enregistrement de l'application
            builder.Services.AddScoped<Application>();

            // Création de l'hôte
            IHost host = builder.Build();

            // Pour démo seulement
            //using (IServiceScope scope = host.Services.CreateScope())
            //{
            //    IJournal journal = scope.ServiceProvider.GetRequiredService<IJournal>();
            //    journal.Avertissement("Attention, il va y avoir une erreur");
            //    journal.Erreur("Erreur 42");
            //    journal.Information("Démarrage de l'application");
            //}

            // Utilisation plus classique
            // On crée un scope pour pouvoir récupérer les services. La notion de scope est liée
            // à la notion de cycle de vie des services. Un service peut être enregistré en tant que
            // singleton (ex. : une seule instance pour toute l'application), en tant que scoped
            // (une instance par scope, par exemple une instance par requête HTTP) ou en tant que
            // transient (une instance à chaque demande). La notion sera revue plus tard. L'essentiel,
            // à ce niveau du cours, est de comprendre l'idée d'injection de dépendances avec la 
            // correspondance entre les interfaces et les implémentations.
            using (IServiceScope scope = host.Services.CreateScope())
            {
                Application app = scope.ServiceProvider.GetRequiredService<Application>();
                app.Run();
            }
        }
    }
}
