# Module 08 - Architecture des applications

## Exercice 1 - Reprise de l'exercice du module 06

Notes : pour des problèmes de longueur de noms de projets et de fichiers, ils ont été raccourcis comme suit :

- DAL : Data access Layer (CoucheAccesDonnees)
- Batch : TraitementLot
- GC : GestionClient

Démarche :

- Créez une solution nommée "GestionClients". Le projet doit se situer à votre racine
- Supprimez le projet "GestionClients"
- Dans cette solution, créez les projets suivants :
  - GC.Entites :
    - Type : Bibliothèque de classes (**.Net core**)
    - Contiendra : les entités (Client, Adresse) et l'interface de dépot
    - Dépendances : aucune
  - GC.DAL.JSON :
    - Type : Bibliothèque de classes (**.Net core**)
    - Contiendra : Le code du dépot et des DTOs de la version JSON
    - Dépendances :
      - GC.Entites
  - GC.DAL.XML :
    - Type : Bibliothèque de classes (**.Net core**)
    - Contiendra : Le code du dépot et des DTOs de la version XML
    - Dépendances :
      - GC.Entites
  - GC.Batch :
    - Type : Bibliothèque de classes (**.Net core**)
    - Contiendra : L'interface des traitements lots
    - Dépendances : aucune
  - GC.Batch.ModifierNomPrenomPremiereLettreMajuscules :
    - Type : Application console
    - Contiendra : La classe du traitement et un nouveau programme principale qui l'instancie
    - Dépendances :
      - GC.Entites
      - GC.DAL.JSON
      - GC.DAL.XML
      - GC.Batch
  - GC.Batch.ModifierPaysMajusculesClients :
    - Type : Application console
    - Contiendra : La classe du traitement et un nouveau programme principale qui l'instancie
    - Dépendances :
      - GC.Entites
      - GC.DAL.JSON
      - GC.DAL.XML
      - GC.Batch
  - GC.ConsoleUI :
    - Type : Application console
    - Contiendra : votre interface console avec le menu et les appels au dépot
    - Dépendances :
      - GC.Entites
      - GC.DAL.JSON
      - GC.DAL.XML
- Dans une autre instance de Visual Studio ouvrez la solution "Module08_Exercice01_Base"
- En adaptant leurs espaces de nommage, copiez les classes de la solution fournie dans les projets adéquat de votre nouvelle solution "GestionClients"
- Testez chacun de vos trois exécutables, c'est à dire, le projet d'interface et les deux traitements batch.
- Faites un diagramme qui explicite les liens entre les projets de la solution : un rectangle par projet et un lien qui part du projet vers un autre s'il y a une dépendance.

## Rendons la solution configurable... (Optionnel mais fortement conseillé de le faire)

Le but de cette section est de pouvoir lancer les trois applications consoles sur le même dépot de clients. Pour cela, vous allez devoir positionner les fichiers de données dans un emplacement accessible par vos applications consoles et leurs indiquer le chemin. Dans cette partie, on se propose d'utiliser les classes du cadriciel .Net afin de lire la configuration dans un fichier JSON.

- Dans vos projets de type console, installez les packages Nuget suivants :  
  - Microsoft.Extensions.Configuration
  - Microsoft.Extensions.Configuration.FileExtensions
  - Microsoft.Extensions.Configuration.Json

- Dans chaque projet "Console", créez un fichier JSON nommé "appsettings.json" (nom usuellement utilisé dans les applications .Net Core) :

```json
{
  "RepertoireDepotsClients": "c:\\tmp",
  "NomFichierDepotClients": "clients.json",
  "TypeDepot" :  "JSON"
}
```

- Modifiez les valeurs pour qu'elles correspondent à votre configuration
- Modifiez les propriétés du fichier pour que la propriété "Copier dans le répertoire de sortie" soit configurée sur "Copier si plus récent". Le fichier sera alors copié au moment de la compilation s'il est plus récent.
- Pour lire la configuration, basez-vous sur le fragment de code suivant qui ajoute le fichier JSON comme source de configuration et va chercher les valeurs :

```csharp
IConfigurationRoot configuration = 
    new ConfigurationBuilder()
          .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
          .AddJsonFile("appsettings.json", false)
          .Build();

string repertoireDepotClient = configuration["RepertoireDepotsClients"];
string nomFichierDepotClient = configuration["NomFichierDepotClients"];
string cheminComplet = Path.Combine(repertoireDepotClient, nomFichierDepotClient);

string typeDepot = configuration["TypeDepot"];
```

- Pour le choix du type de dépot, vous pouvez vous inspirer du fragment de code suivant :

```csharp
switch (typeDepot.ToLower())
{
    case "json":
        conteneur.RegisterType<IDepotClients, DepotClientsJSON>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { cheminComplet }));
        break;
    case "xml":
        conteneur.RegisterType<IDepotClients, DepotClientsXML>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { cheminComplet }));
        break;
    default:
        throw new InvalidOperationException("le type de dépot n'est pas valide, mettre json ou xml");
}
```

## Début de déploiement (Optionnel mais fortement conseillé de le faire)

Votre solution permet de créer 3 applications consoles : deux traitements et une application qui intéragit avec l'utilisateur.

- Utilisez le gestionnaire de configuration pour que la configuration de la cible soit "Release" à la place de "Debug"
- Allez dans "Générer" > "Générer la solution"
- Naviguez les répertoires "Bin\Release\[plateforme]". Copiez chaque contenu dans un répertoire indépendant qui a comme répertoire parent "C:\POOII\GestionClients\".
- À partir d'une ligne de commande Windows ou PowerShell, essayez d'exécuter ces applications. Déboguez le cas échéant.
