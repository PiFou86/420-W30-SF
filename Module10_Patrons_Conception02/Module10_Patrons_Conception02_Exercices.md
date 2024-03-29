# Module 10 - Patron de conception 02

## Exercice 1 - Caisse enregistreuse

Dans cet exercice, nous allons simuler une partie d'une caisse enregistreuse.

L'application simule deux périphériques de sortie : l'écran principal et l'écran client. L'écran principal affiche la facture ainsi qu'une zone de saisie qui permet de simuler un scanner de codes barre. L'écran monoligne du client affiche "Bienvenue" pour accueillir un nouveau client. Ensuite, à chaque nouvelle ligne saisie (simulation du scanner), l'écran affiche la description de l'article, la quantité et le prix total.

![Écrans au démarrage](img/Ecran_demarrage.png)

<details>
    <summary>Proposition de diagramme de classes (Voir après réflexion personnelle !)</summary>

Le schéma suivant représente une vue globale de l'application avec des observateurs non génériques (version temporaire) :

![Diagramme de classes](../images/Module10_Patrons_Conception02/diag/DiagFacture/DiagAppFactureNonGen.png)

Le schéma suivant représente une vue globale de l'application avec des observateurs génériques (version de l'exercice suivant) :

![Diagramme de classes](../images/Module10_Patrons_Conception02/diag/DiagFactureGen/DiagAppFactureGen.png)

La version génériques permet de limiter le nombre de classes en prenant une stratégie en paramètres. Cette stratégie correspond au traitement de l'événement. Cette version évite aussi de passer les éléments graphiques en paramètres du constructeur.

</details>

### Exercice 1.1 - Écran principal

- Reproduisez l'écran principal
  - Pour l'affichage de la facture, utilisez un "DataGridView". Empêchez l'édition dans ce contrôle.
  - Pour la simulation, mettez tous les contrôles dans un "GroupBox".
  - Les saisies d'entiers ou de décimaux doivent être effectuées avec des contrôles de type "NumericUpDown"

![Contrôles fPrincipale](img/fPrincipale_composants.png)

- La fenêtre doit pouvoir être redimensionnée tout en gardant son aspect :

![fPrincipal redimensionnement](img/fPrincipale_redim.png)

### Exercice 1.2 - Écran client

Reproduisez l'écran client :

![Écran client](img/fClient.png)

### Exercice 1.3 - Facture

Pour simplifier le codage, il y aura une seule instance de "FactureModel". Cette instance sera créée par "fPrincipal". La facture est le sujet et les deux fenêtres vont créer des observateurs sur elle. Seul le simulateur de scanner ("Simuler") et le paiement ("Payer") pourront agir directement la facture.

Étapes à suivre pour cette partie de l'exercice:

- Créez la classe "FactureModel" qui permet de stocker des lignes de facture
- Une ligne de facture à une description, une quantité, un prix unitaire et un total
- La facture doit implanter l'interface "IObservable". Le type d'éléments envoyé pour les notifications est "FactureModelEvent".
- "FactureModelEvent" contient trois propriétés :
  - Type : type de l'événement, soit "AJOUT_LIGNE" envoyé pour l'ajout d'une ligne dans la facture, soit "NOUVELLE" pour la création d'une nouvelle facture. Pour cette propriété, créez le type "TypeEvenementFactureModel" comment [étant un "enum"](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)
  - LigneFactureModel : référence de la ligne de facture quand le type d'événement est "AJOUT_LIGNE", null sinon
  - FactureModel : référence de la facture qui a déclenchée l'événement
- La facture doit implanter une méthode pour l'ajout d'une ligne de facture. Cet ajout doit aussi s'occuper de notifier les observateurs de l'événement.
- La facture doit implanter une méthode pour la suppression de toutes les lignes de la facture. Cet ajout doit aussi s'occuper de notifier les observateurs de l'événement.

### Exercice 1.4 - Observateurs

- Créez la classe "ObservateurFactureModel" qui implante l'interface "IObserver<FactureModelEvent>"
- Cette classe doit avoir un constructeur par initialisation qui prend une lambda en paramètres et qui réagit au "FactureModelEvent" passé en paramètres
- En utilisant la classe "ObservateurFactureModel" et des lambdas appropriées :
  - Au moment de la réception d'une nouvelle ligne :
    - Ajoutez la ligne dans le "DataGridView"
    - Affichez la ligne ajoutée sur l'écran du client
![Affichage après ajout d'une ligne](img/Ecran_avec_donnees.png)

  - Au moment de la réception d'une demande de nouvelle facture :
    - Videz le "DataGridView"
    - Affichez "Bienvenue" sur l'écran client
![Écrans au démarrage](img/Ecran_demarrage.png)

  - Vérifiez manuellement que tout fonctionne
  
## Exercice 1.5 - Ajout d'une simulation d'imprimante (Optionnel)

Ajoutez une autre fenêtre qui va simuler une imprimant de tickets de caisse. À l'ajout du premier article, l'imprimante inscrit les informations de l'entreprise. À l'événement d'une nouvelle facture, l'imprimante inscrit le total et remercie le client de sa visite.

## Exercice 2 - Copie de fichiers (Optionnel)

Dans cet exercice, vous devez proposer une interface qui propose de copier un répertoire vers un autre en affichant l'avancement avec une barre de progression.

Le premier est le répertoire à copier. Le second est le répertoire de destination. Le répertoire de destination doit exister et être vide.

Si toutes les conditions sont rencontrées, l'utilisateur peut cliquer sur un bouton qui démarre la copie.

Durant la copie, l'utilisateur doit pouvoir annuler la copie en cliquant sur un bouton.

La copie doit être effectuée en arrière plan. Pour implanter la copie en arrière plan, vous devez utiliser la classe [BackgroundWorker](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.backgroundworker?view=netcore-3.1).

Pour l'algorithme de copie, vous devez ouvrir chaque fichier en binaire : le premier en lecture, le second en écriture. Chaque lecture doit être d'au minimum 512 octets.
