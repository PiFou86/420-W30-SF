# Module 01 - Révisions

## Exercice 1 - Tasses

Un contenant peut contenir plusieurs liquides. Les liquides disponibles sont du lait, du café, de la crème et du chocolat.

Chaque liquide a un volume. Le volume total ne doit pas dépasser le volume du contenant moins 5%.

Les contenants disponibles sont du type bol ou tasse. Une tasse a un volume de 250ml. Un bol a un volume de 350 ml.

Un liquide peut être ajouté à un contenant tant que celui-ci n'est pas plein. Un contenant peut perdre du volume en le transférant.

Les contenants et les liquides doivent pouvoir être transformés facilement en chaînes de caractères afin, par exemple, de facilement être affichés :

- Pour un contenant, on extrait l'ensemble des liquides mélangés, le volume total maximum (capacité), le volume utilisé et le pourcentage de remplissage.
- Pour un liquide, on extrait son nom et son volume.

Modélisez le problème en faisant apparaître toutes les entités présentes dans le texte.

- Proposez un diagramme de classes
- Codez ces classes
- Faites des méthodes qui renvoient différentes types de cafés dans différents types de contenants
- Faites les tests unitaires de la génération des chaînes de caractères
- Faites les tests unitaires de l'ajout d'un liquide dans une tasse et dans un bol

## Exercice 2 - Assemblage

Une pièce est composée de 0 ou de plusieurs autres pièces. Une pièce peut être soit de type pièces d'assemblage (vis, rivêts), soit de type moulée ou de type usinée.

Chaque pièce a une description, un numéro de série et une référence. Chaque pièce peut être transformée en chaînes de caractères. Chaque pièce se décrit et demande aux pièces qui le composent de se décrire.

Afin de rendre compte de la hiérarchie des pièces (pièces composées de pièces, etc.), les chaînes doivent être préfixées par des espaces dépendants de leur niveau. (2 espaces par niveau)

Exemple :
```console
Pièce : Axe Y, part - #2351, numéro série -  #0481
  Pièce : Vis sans fin avec écrou T8, part - #2251, numéro série -  #0235
    Pièce : Écrou laiton , part - #2253, numéro série -  #0233
    Pièce : Vis sans fin , part - #2257, numéro série -  #0230
  Pièce : Vis sans fin avec écrou T8, part - #2251, numéro série -  #1235
    Pièce : Écrou laiton , part - #2253, numéro série -  #1233
    Pièce : Vis sans fin , part - #2257, numéro série -  #1230
  Pièce : Moteur Nema 23, part - #2051, numero serie - #9571
  Pièce : Moteur Nema 23, part - #2051, numero serie - #9574
```
