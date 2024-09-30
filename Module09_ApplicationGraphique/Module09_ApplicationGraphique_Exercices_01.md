# Module 09 - Application graphique 1 / 2

Dans cette première partie du module, nous allons utiliser créer une première application graphique qui reproduit un logiciel d'édition de fichiers texte.

## Exercice 1 - Super bloc-notes - Design

- Créez le projet Visual Studio "Module 09 - Super bloc-notes" de type "Windows Forms App (.Net Core)"
- Modifiez la fenêtre principale :
  - Nom de la classe : "fPrincipale"
  - Titre : "Super Bloc-notes"
  - Icône : Cherchez un icône de bloc-notes sur Google image ("ICO")
- Dans la fenêtre principale, ajoutez le menu fichier avec les options suivantes :
  - "Nouveau" : raccourci "Ctrl+N"
  - "Ouvrir" : raccourci "Ctrl+O"
  - "Enregistrer" : raccourci "Ctrl+S"
  - "Enregistrer sous..." : raccourci "Ctrl+Maj+S"
  - Un séparateur de menu
  - "Quitter" : raccourci "Alt+F4"
- Toujours dans la fenêtre principale, ajoutez une zone de texte multi-lignes qui prend tout le reste de l'espace et adaptez les propriétés de ce contrôle pour que l'apparence reste la même en cas de redimensionnement. La zone multi-lignes doit avoir le nom "tbTexte"
- Lancez l'application et valider que tout fonctionnne

## Exercice 2 - Programmation de l'application

- Programmez les comportements suivants :
  - Quand l'utilisateur clique sur "Nouveau", le programme doit vider le contenu du contrôle "tbTexte"
  - Quand l'utilisateur clique sur "Ouvrir", utilisez la classe "OpenFileDialog" pour faire apparaitre une fenêtre de choix de fichiers. Par défaut, seuls les fichiers texte sont affichés. Si l'utilisateur clique sur "Ouvrir", le contrôle "tbTexte" doit faire apparaitre le texte
  - Quand l'utilisateur clique sur "Enregistrer", si un fichier a été précédemment ouvert, vous devez prendre le contenu de "tbTexte" et l'enregistrer dans ce dernier
  - Quand l'utilisateur clique sur "Enregistrer sous...", vous devez proposer à l'utilisateur de choisir un nom de fichier en vous aidant de la classe "SaveFileDialog" avec un filtre de type fichiers texte ("*.txt")
  - Quand l'utilisateur clique sur "Quitter", vous devez quitter l'application en fermant la fenêtre principale
- Validez que tout fonctionne

## Exercice 3 - Ne pas perdre ses modifications

- En vous aidant de l'événement "Texte changed" du contrôle "tbTexte", validez que l'utilisateur ne perd pas ses modifications quand il choisit "Nouveau", "Ouvrir" et "Quitter"
- Validez que tout fonctionne

## Exercice 4 - Un menu édition ? (Optionnel)

- Ajoutez un menu "Édition" avec les options :
  - Copier : raccourci "Ctrl+C"
  - Couper : raccourci "Ctrl+X"
  - Coller : raccourci "Ctrl+V"
- Programmez les événements en vous aidant des méthodes "Cut/Copy/Paste" et "Selection*" du contrôle "tbTexte"
- Validez que tout fonctionne
- **Pour les intrépides** Reprogrammez ces événements en vous aidant de la [classe "ClipBoard"](https://docs.microsoft.com/en-us/dotnet/api/system.windows.clipboard.gettext?view=netcore-3.1) (Voir méthodes statiques GetText et SetText) et des propriétés "Selected*" et "Selection*" du contrôle "tbTexte"
- Validez que tout fonctionne
