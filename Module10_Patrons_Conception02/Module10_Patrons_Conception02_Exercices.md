# Module 10 - Patron de conception 02

Dans ce module, nous allons simuler une partie d'une caisse enregistreuse.

L'application simule deux périphériques de sortie : l'écran principal et l'écran client. L'écran principal affiche la facture ainsi qu'une zone de saisie qui permet de simuler un scanner de codes barre. L'écran monoligne du client affiche "Bienvenue" pour accueillir un nouveau client. Ensuite, à chaque nouvelle ligne saisie (simulation du scanner), l'écran affiche la description de l'article, la quantité et le prix total.

![Écrans au démarrage](img/Ecran_demarrage.png)

## Écran principal

- Reproduisez l'écran principal. 
  - Pour l'affichage de la facture, utilisez un "DataGridView". Empêchez l'édition dans ce contrôle.
  - Pour la simulation, mettez tous les contrôles dans un "GroupBox".
  - Les saisies d'entiers ou de décimaux doivent être effectuées avec des contrôles de type "NumericUpDown

![Contrôles fPrincipale](img/fPrincipale_composants.png)

- La fenêtre doit pouvoir être redimensionnée tout en gardant son aspect :

![fPrincipal redimensionnement](img/fPrincipale_redim.png)

## Écran client

Reproduisez l'écran client :

![Écran client](img/fClient.png)

## Facture

- Créez une classe facture qui permet de stocker des lignes de facture
- La facture doit être implanter l'interface "IObservable". Le type d'éléments envoyé pour les notifications est "FactureEvent".
- "FactureEvent" contient trois propriétés :
  - Type : type de l'événement, soit "AJOUT_LIGNE" envoyé pour l'ajout d'une ligne dans la facture, soit "NOUVELLE" pour la création d'une nouvelle facture.
  - LigneFacture : référence de la ligne de facture quand le type d'événement est "AJOUT_LIGNE", null sinon
  - Facture : référence de la facture qui a déclenchée l'événement
- La facture doit implanter une méthode pour l'ajout d'une ligne de facture. Cet ajout doit aussi s'occuper de notifier les observateurs de l'événement.
- La facture doit implanter une méthode pour la suppression de toutes les lignes de la facture. Cet ajout doit aussi s'occuper de notifier les observateurs de l'événement.

## Observateurs

- Créez la classe "ObservateurFacture" qui implante l'interface "IObserver<FactureEvent>"
- Cette classe doit avoir un constructeur par initialisation qui prend une lambda en paramètres et qui réagit au "FactureEvent" passé en paramètres
- En utilisant la classe "ObservateurFacture" et des lambdas appropriées :
  - Au moment de la réception d'une nouvelle ligne :
    - Ajoutez la ligne dans le "DataGridView"
    - Affichez la ligne ajoutée sur l'écran du client
![Affichage après ajout d'une ligne](img/Ecran_avec_donnees.png)

  - Au moment de la réception d'une demande de nouvelle facture :
    - Videz le "DataGridView"
    - Affichez "Bienvenue" sur l'écran client
![Écrans au démarrage](img/Ecran_demarrage.png)

  - Vérifiez que tout fonctionne
