# Module 08 - Architecture des applications

---
**NOTE**

Pour cet exercice, vous devez vous baser sur les fragments de code fournis. L'objectif n'est pas que vous reteniez par coeur chaque ligne de code, mais que **vous compreniez ce qu'elles font** et que vous soyez capable d'aller les trouver, c'est à dire vous souvenir que cela existe.

Les principaux buts sont :

- Renforcer la compréhension d'un design d'application complexe
- Découper une application en couches
- Organiser ces couches dans des projets Visual Studio
- Créer plusieurs applications exécutable
- Rendre vos applications configurable
- Préparer vos applications pour un déploiement
- Simuler le déploiement d'applications en les déployant sur votre station de développement

---

## Exercice 1 - Reprise de l'exercice du module 06

Notes : pour des problèmes de longueur de noms de projets et de chemins de fichiers, les abréviations suivantes sont utilisées :

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
- Lancez (exécutez) chacun de vos trois exécutables, c'est à dire, le projet d'interface utilisateur et les deux traitements batch.
- Faites un diagramme (vous pouvez utiliser un diagramme de packages) qui explicite les liens entre les projets de la solution : un rectangle par projet et un lien qui part du projet vers un autre s'il y a une dépendance.

## Exercice 2 - Rendons la solution configurable...

Le but de cette section est de pouvoir lancer les trois applications consoles sur **le même dépot de clients**. Pour cela, vous allez devoir positionner les fichiers de données dans un emplacement accessible par vos applications consoles et leurs indiquer le chemin. Dans cette partie, on se propose d'utiliser les classes du cadriciel .Net afin de lire la configuration dans un fichier JSON.

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

- Modifiez les valeurs pour qu'elles correspondent à votre configuration : répertoire contenant votre dépôt de client, nom du fichier (dépendant du format choisi) et type de dépot (soit json, soit xml)
- Modifiez les propriétés du fichier pour que la propriété "Copier dans le répertoire de sortie" soit configurée sur "Copier si plus récent". Le fichier sera alors copié au moment de la compilation s'il est plus récent.
- Copiez les fichiers présents dans le répertoire "Donnees" du présent dossier dans le répertoire que vous avez configuré dans les fichiers "appsettings.json" de vos applications console. Dans le cas de l'exemple donné, les fichiers seraient copiés dans le répertoire "tmp" de votre lecteur "C".
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

## Exercice 3 - Début de déploiement

Votre solution permet de créer 3 applications consoles : deux traitements et une application qui intéragit avec l'utilisateur.

L'application "GC.ConsoleUI" est destinée à des utilisateurs. Elle est lancée manuellement au besoin.

Les applications de traitements seraient normalement installées sur d'autres ressources de calculs et seraient lancées régulièrement par un planificateur de tâches.

- Utilisez le gestionnaire de configuration pour que la configuration de la cible soit "Release" à la place de "Debug"
- Allez dans "Générer" > "Générer la solution"
- Naviguez les répertoires "Bin\Release\[plateforme]". Copiez chaque contenu dans un répertoire indépendant qui a comme répertoire parent "C:\POOII\GestionClients\" :

```console
POOII
└── GestionClients
   ├── GC.Batch.ModifierNomPrenomPremiereLettreMajuscules
   ├── GC.Batch.ModifierPaysMajusculesClients
   └── GC.ConsoleUI
```

- À partir d'une ligne de commande Windows ou PowerShell, essayez d'exécuter ces applications. Déboguez le cas échéant :

```powershell
# Si vous n'avez pas de fichier exécutable utilisez la commande suivante :
dotnet [NomProjet].dll

# Si vous avez un fichier exécutable :
./[NomProjet].exe
```
