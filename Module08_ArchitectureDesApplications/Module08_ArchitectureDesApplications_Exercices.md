# Module 08 - Architecture des applications

## Exercice 1 - Reprise de l'exercice du module 06

Notes :

- Le terme DAL (Data access Layer) remplace le sens francais DAL
- Le terme Batch remplace le sens francais Batch

Démarche :

- Créez une solution nommée "Module08_ArchitectureDesApplication". Le projet doit se situer à votre racine
- Supprimez le projet "GestionClients"
- Dans cette solution, créez les projets suivants :
  - GestionClients.Entites :
    - Type : Bibliothèque de classes
    - Contiendra : les entités (Client, Adresse) et l'interface de dépot
    - Dépendances : aucune
  - GestionClients.DAL.JSON :
    - Type : Bibliothèque de classes
    - Contiendra : Le code du dépot JSON et la version du dépot JSON
    - Dépendances :
      - GestionClients.Entites
  - GestionClients.DAL.XML :
    - Type : Bibliothèque de classes
    - Contiendra : Le code du dépot JSON et la version du dépot XML
    - Dépendances :
      - GestionClients.Entites
  - GestionClients.Batch :
    - Type : Bibliothèque de classes
    - Contiendra : L'interface des traitements lots
    - Dépendances : aucune
  - GestionClients.Batch.ModifierNomPrenomPremiereLettreMajuscules :
    - Type : Application console
    - Contiendra : La classe du traitement et un nouveau programme principale qui l'instancie
    - Dépendances :
      - GestionClients.Entites
      - GestionClients.DAL.JSON
      - GestionClients.DAL.XML
  - GestionClients.Batch.ModifierPaysMajusculesClients :
    - Type : Application console
    - Contiendra : La classe du traitement et un nouveau programme principale qui l'instancie
    - Dépendances :
      - GestionClients.Entites
      - GestionClients.DAL.JSON
      - GestionClients.DAL.XML
  - GestionClients.UI.Console :
    - Type : Application console
    - Contiendra : votre interface console avec le menu et les appels au dépot
    - Dépendances :
      - GestionClients.Entites
      - GestionClients.DAL.JSON
      - GestionClients.DAL.XML
- Dans une autre instance de Visual Studio ouvrez la solution "Module08_Exercice01_Base"
- En adaptant leurs espaces de nommage, copiez les classes de la solution fournie dans les projets adéquat de votre nouvelle solution "GestionClients"
- Testez chacun de vos trois exécutables, c'est à dire, le projet d'interface et les deux traitements batch.
