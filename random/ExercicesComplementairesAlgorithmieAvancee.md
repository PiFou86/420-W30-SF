
# Exercices complémentaires - Algorithmie avancée
## Exercice 1 – Suivi des opérations d’une pile

Cet exercice a pour but de se familiariser avec les manipulations des piles et des files.

A - Considérez une pile P d’entiers initialement vide à laquelle on applique les opérations suivantes :
```csharp
P.empiler(21);  
P.empiler(12);  
P.sommet();  
P.empiler(35)
```

Veuillez dessiner l’état courant de la pile.  
```csharp
P.depiler();  
P.empiler(32);  
P.empiler(47);  
P.depiler();  
P.empiler(79);
```

Veuillez dessiner le nouvel état de la pile.

Qu’arriverait-il si on affichait à la console le résultat de ```P.sommet()```? Qu’est-ce qui serait différent si on affichait le résultat de ```P.dépiler()```?

B -  Considérez une file F d’entiers initialement vide à laquelle on applique les opérations suivantes :
```csharp
F.enfiler(10);  
F.enfiler(15);  
F.enfiler(5);  
F.enfiler(35)  
F.tete();
```

Veuillez dessiner l’état courant de la file.  
```csharp
F.enfiler(32);  
F.defiler();  
F.defiler();  
F.enfiler(47);  
F.enfiler(79);
```
Veuillez dessiner le nouvel état de la pile.

Qu’arriverait-il si on affichait à la console le résultat de F.tete()? Qu’est-ce qui serait différent si on affichait le résultat de P.défiler()?
## Exercice 2 – Algorithmes avec piles et files


Cet exercice a pour but de se familiariser avec des manipulations algorithmiques sur les piles et les files. 
Pour les algorithmes suivant, veuillez
1.	Décrire en texte les étapes à effectuer en pseudo-code 
2.	Indiquer le nombre et le type des structures de données utilisées dans l’algorithme
3.	Déterminer la complexité de l’algorithme conçu 

A - Nous cherchons un algorithme permettant d’inverser une pile avec la restriction suivante :
*Vous pouvez seulement utiliser des piles pour inverser la pile.*
L’algorithme doit recevoir en paramètre une référence (mot-clé ref en C#) de pile et la modifier sur place de façon que la pile soit inversée. 
Exemple en pseudo-code avec une pile P:
```csharp
P.empiler(1)
P.empiler(2) 
RenverserPile(référence de P)
Afficher(P.sommet()) //devrait afficher 1
```
B – Nous cherchons encore un algorithme permettant d’inverser une pile, cette fois-ci avec la restriction suivante:
*Vous pouvez seulement utiliser des files pour inverser la pile.*
L’algorithme doit avoir les mêmes paramètres et résultats que l’algorithme A.

C – Nous cherchons un algorithme permettant de copier une pile avec la restriction suivante :
*Vous pouvez seulement utiliser des piles pour effectuer la copie.*
L’algorithme doit donc retourner une pile qui a les mêmes éléments qu’une pile passée en paramètre en s’assurant de laisser la pile passée en paramètre intacte. 
Exemple en pseudo-code avec une pile P:
```csharp
P.empiler(1)
P.empiler(2) 
P2 = CopierPile(P)
Afficher(P.sommet()) //devrait afficher 2.
Afficher(P2.sommet()) //devrait aussi afficher 2 
```
D – Nous cherchons un algorithme permettant de copier une file avec la restriction suivante :
*Vous pouvez seulement utiliser des piles pour effectuer la copie (excepté la file à
copier et la file de copie, bien sûr).*
L’algorithme doit donc retourner une file qui a les mêmes éléments qu’une file passée en paramètre en s’assurant de laisser la file passée en paramètre intacte.
Exemple en pseudo-code avec une file F:
```csharp
F.enfiler(1)
F.enfiler(2) 
F2 = CopierFile(F)
Afficher(F.tete()) //devrait afficher 1. 
Afficher(F2.tete()) //devrait aussi afficher 1.
```
## Exercice 3 – Implémentation des algorithmes sur des piles et files
Vous devez maintenant implémenter, en C#, les algorithmes que vous avez conçu à l’exercice 2.
Pour cela : 
Créez une classe ManipulationStructures qui admet les méthodes suivantes :
1. ```public void InverserPileAvecPile<T>(ref Stack<T> p_pile)```
2. ```public void InverserPileAvecFile<T>(ref Stack<T> p_pile)```
3. ```public Stack<T> CopierPile<T>(Stack<T> p_pile)```
4. ```public Queue<T> CopierFile<T>(Queue<T> p_file)```

Implémentez les méthodes avec les algorithmes que vous avez conçu.

Pour les classes Stack et Queue, vous pouvez utiliser les classes offertes par C# ou que vous avez implémenté vous-même. Cependant, vous pouvez seulement utiliser les méthodes Pop/Dequeue (Dépiler/Défiler), Push/Enqueue (Empiler/Enfiler) et Peek (Sommet/Tête).

Écrivez les tests unitaires pour les quatre méthodes. 
Que remarquez-vous sur votre stratégie de tests pour les deux premières méthodes? 
Qu’est-ce que leurs tests ont en commun? Pourquoi?

