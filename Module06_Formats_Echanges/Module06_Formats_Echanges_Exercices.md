# Module 06 - Formats d'échanges

## Exercice 1 - Clients

Un client est défini par :

- Un identifiant de type Guid
- Un prénom et un nom
- Une liste d'adresses

Une adresse est définie par :

- Un numéro civique
- Une information complémentaire (app, etc.) de type chaîne
- Un odonyme
- Un type de voie
- Code postal
- Nom municipalité
- État
- Pays

1. Implantez les classes nécessaires à représentation d'un client.
2. Écrivez une interface de type dépot qui permet d'ajouter un client, effectuer la recherche d'un client par son identifiant et lister tous les clients.
3. Écrivez deux classes qui implante l'interface précédente et qui implantent  respectivement un dépot de type XML (le format est libre) et un dépôt JSON.
4. Créez une application console qui permet de manipuler un dépôt à l'aide d'un menu. L'application console doit être codée dans la classe "ClientUIConsole". Elle reçoit le dépôt au moment de son initialisation.
Afin de simplifier l'écriture du code, la saisie de l'adresse peut-être simulée par une méthode qui renvoie des adresses aléatoires.
5. Utilisez le cadriciel d'injection de dépendances "Unity" afin d'injecter le dépot au moment de l'instanciation d'un objet de la classe "ClientUIConsole".
