using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using POOII_M01_E02_DI_Interfaces;
using POOII_M01_E02_DI_Journaux;

namespace POOII_M01_E02_DI_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

            string? typeJournalisation = builder.Configuration["journal"];
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

            builder.Services.AddScoped<Application>();

            IHost host = builder.Build();

            using (IServiceScope scope = host.Services.CreateScope())
            {
                IJournal journal = scope.ServiceProvider.GetRequiredService<IJournal>();
                journal.Avertissement("Attention, il va y avoir une erreur");
                journal.Erreur("Erreur 42");
                journal.Information("Démarrage de l'application");
            }

            using (IServiceScope scope = host.Services.CreateScope())
            {
                Application app = scope.ServiceProvider.GetRequiredService<Application>();
                app.Run();
            }
        }
    }
}
