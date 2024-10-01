// Pour facilité l'injection de dépendances nous allon utiliser le package Microsoft.Extensions.Hosting
// pour construire la configuration.
// Afin de pouvoir définir des configurations, nous allons utiliser le mécanisme de configuration
// par défaut de .NET Core, qui est basé sur le package Microsoft.Extensions.Configuration.
// Pour spécifier la configuration de l'application, nous allons utiliser le fichier appsettings.json.
// Nous allons ajouter la langue à utiliser dans l'application, en utilisant la configuration.
// Afin que le fichier appsettings.json soit copié durant la compilation, nous allons configurer
// la propriété "Copy to Output Directory" du fichier "appsettings.json" à "Copy if newer".

using M01_DI_Implantation;
using M01_DI_Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using POOII_M01_InjectionDependances;

string? nom = "Dragona";

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

string? langue = builder.Configuration["langue"];

switch (langue)
{
    case "fr":
        builder.Services.AddScoped<ISalutation, SalutationFrancais>();
        break;
    case "en":
        builder.Services.AddScoped<ISalutation, SalutationAnglais>();
        break;
    case "eu":
        builder.Services.AddScoped<ISalutation, SalutationBasque>();
        break;
    default:
        throw new ArgumentException("Langue non supportée");
}
builder.Services.AddScoped<AutreClasse>();

IHost host = builder.Build();

using (IServiceScope scope = host.Services.CreateScope())
{
    ISalutation salutation = scope.ServiceProvider.GetRequiredService<ISalutation>();
    salutation.Saluer(nom);
}

using (IServiceScope scope = host.Services.CreateScope())
{
    AutreClasse autreClasse = scope.ServiceProvider.GetRequiredService<AutreClasse>();
    autreClasse.Saluer(nom);
}