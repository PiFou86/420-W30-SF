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

Exemple basé sur l'illustration proposée par Eder Rafael Do Monte Melo ([fichier PowerPoint plus détaillé](Illustration_Piece_Eder/Assemblage.pptx)) :

![Valve d'eau](../images/Module01_Revisions/pieces_illustration_Eder.png)

```console
Pièce : Valve à eau, part - #1234, numéro série -  #0481
  Pièce : Base, part - #1387, numéro série -  #0474
  Pièce : Système d'activation, part - #1887, numéro série -  #0574
    Pièce : Pin, part - #1687, numéro série -  #0974
    Pièce : Plug, part - #1657, numéro série -  #0964
    Pièce : Poigné, part - #3157, numéro série -  #2547
  Pièce : Couvercle latérale, part - #1987, numéro série -  #0374
    Pièce : Couvercle Monobloc, part - #1257, numéro série -  #9874
    Pièce : Visse M8, part - #8757, numéro série -  #3774
    Pièce : Visse M8, part - #8757, numéro série -  #3774
    Pièce : Visse M8, part - #8757, numéro série -  #3774
    Pièce : Visse M8, part - #8757, numéro série -  #3774
  Pièce : Couvercle latérale, part - #1987, numéro série -  #0374
    Pièce : Couvercle Monobloc, part - #1257, numéro série -  #9874
    Pièce : Visse M8, part - #8757, numéro série -  #3774
    Pièce : Visse M8, part - #8757, numéro série -  #3774
    Pièce : Visse M8, part - #8757, numéro série -  #3774
    Pièce : Visse M8, part - #8757, numéro série -  #3774
```

**Pour les plus téméraires** : écrivez une méthode qui, à partir du pièce, renvoie sa nomenclature (BOM : Bill of Materials)

Toujours avec le même exemple :

```console
Description                             Référence  Nombre
Valve à eau                             1234       1
Couvercle Monobloc                      1257       2
Base                                    1387       1
Plug                                    1657       1
Pin                                     1687       1
Système d'activation                    1887       1
Couvercle latérale                      1987       2
Poigné                                  3157       1
Visse M8                                8757       8
```