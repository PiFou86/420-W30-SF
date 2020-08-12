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
