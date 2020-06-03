# Module 03 - Traitement des exceptions et exceptions utilisateur

## Exercice 1 - Lecture dans un fichier

Faîtes un programme C# qui demande à l'utilisateur le chemin absolu d'un fichier texte et qui l'affiche à l'écran.

Ne cherchez pas à valider si le fichier existe. Si une erreur est détectée durant l'ouverture du fichier, affichez un message spécifique en français de l'erreur, le message original ainsi que la pile d'appels.

Pour ouvrir le fichier texte en lecture, inspirez-vous du code suivant :
```csharp
using (StreamReader sr = new StreamReader(nomFichier))
{
    // Tant que nous ne sommes pas arrivés à la fin du fichier
    while (!sr.EndOfStream)
    {
        // Lire une ligne
        string ligneActuelleDuFichier = sr.ReadLine();
        // Utilisez ligneActuelleDuFichier en complétant...
    }
}
```

## Exercice 2 - Matrices

Le but de l'exercice est de se doter d'une bibliothèque permettant de faire des calculs sur des matrices 2D.

En cas de paramètres incorrectes, vous devez créer vos propres exceptions. Créez la classe d'exception "DimensionsNonConcordantesException". Elle devrait vous servir pour les préconditions. (De quelle classe vos classes d'exception vont hériter ?)

Créez la classe "Matrice2D" qui permet de représenter des matrices 2D. Le type de valeurs de votre matrice est float.

Les données peuvent être représentées par une tableau à deux dimensions. Pour cela, vous pouvez vous inspirer de l'exemple suivant sur les tableaux 2D :

```csharp
double[,] tableau2D = new double[3, 4];
Console.Out.WriteLine($"Nombre de dimension : {tableau2D.Rank}");
Console.Out.WriteLine($"Capacité dimension 1 : {tableau2D.GetLength(0)}");
Console.Out.WriteLine($"Capacité dimension 2 : {tableau2D.GetLength(1)}");
for (int indiceLigne = 0; indiceLigne < tableau2D.GetLength(0); indiceLigne++)
{
    Console.Out.Write(tableau2D[indiceLigne, 0]);
    for (int indiceColonne = 1; indiceColonne < tableau2D.GetLength(1); indiceColonne++)
    {
        Console.Out.Write($", {tableau2D[indiceLigne, indiceColonne]}");
    }
    Console.Out.WriteLine();
}
```

Écrivez les propriétés suivantes :

- [int p_ligne, int p_colonne] : permet d'accèder à une valeur par sa ligne et sa colonne
- NombreDeLignes (get seulement) : permet de connaitre le nombre de lignes de la matrice
- NombreDeColonnes (get seulement) : permet de connaitre le nombre de colonnes de la matrice

Écrivez les méthodes suivantes :

- "Identite" : prend en paramètres une dimension de matrice et renvoie la matrice carré identité correspondante à la dimension.
- "Transpose" : prend une matrice en paramètre et renvoie sa transposée.

Écrivez les opérateurs suivants ([Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading)) :

- \* : prend deux matrices en paramètres et renvoie le résultat de la multiplication de ces deux matrices
- \* : prend une matrice et une valeur v en paramètres et renvoie le résultat de la multiplication de chaque valeur de la matrice par la valeur v
- +/-: prend deux matrices en paramètres et renvoie une nouvelle matrice dont chaque case correspond à la somme des cases aux mêmes coordonnées prisent dans les deux opérandes

