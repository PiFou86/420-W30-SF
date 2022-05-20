# Exercice 1 - Tasses

## Version 1

Ici on explicite les contenants et les liquides. Ajouter un contenant ou un liquide revient à créer de nouvelles classes. Les valeurs de noms et de volumes sont données par les constructeurs par défaut des classes filles qui appellent le constructeur d'initialisation de la classe mère.

![Diagramme de classes - Version 1](images/diag/version1/Version1.png)

## Version 2

Ici on explicite les contenants et les liquides. Ajouter un contenant ou un liquide revient à créer de nouvelles classes. Les valeurs de noms et de Volume sont données par défaut par les propriétés redéfinies dans les classes filles.

![Diagramme de classes - Version 2](images/diag/version2/Version2.png)

## Version 3

Ici on cherche à rester très générique. L'ajout de contenants ou de liquides ne nécessite pas de changer de code.

![Diagramme de classes - Version 3](images/diag/version3/Version3.png)
