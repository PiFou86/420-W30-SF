++++++++++          Affecte 10 à la case 0
[                   Boucle initiale qui affecte des valeurs utiles au tableau 
   >                avance à la case 1 
   +++++++          affecte 7 à la case 1
   >                avance à la case 2
   ++++++++++       affecte 10 à la case 2 
   >                avance à la case 3
   +++              affecte 3 à la case 3
   >                avance à la case 4
   +                affecte 1 à la case 4
   <<<<             retourne à la case 0
   -                enlève 1 à la case 0
]                   jusqu'à ce que la case 0 soit = à 0
la boucle initialise le tableau selon les valeurs suivantes:
Case : Valeur
0 : 0
1 : 70
2 : 100
3 : 30
4 : 10

>++                    ajoute 2 à la case 1 (70 plus 2 = 72)
.                      imprime le caractère 'H' (72)
>+                     ajoute 1 à la case 2 (100 plus 1 = 101)
.                      imprime le caractère 'e' (101)
+++++++                ajoute 7 à la case 2 (101 plus 7 = 108)
.                      imprime le caractère 'l'  (108)
.                      imprime le caractère 'l'  (108)
+++                    ajoute 3 à la case 2 (108 plus 3 = 111)
.                      imprime le caractère 'o' (111)
>++                    ajoute 2 à la case 3 (30 plus 2 = 32)
.                      imprime le caractère ' '(espace) (32)
<<                     revient à la case 1
+++++++++++++++        ajoute 15 à la case 1 (72 plus 15 = 87)
.                      imprime le caractère 'W' (87)
>                      repart à la case 2
.                      imprime le caractère 'o' (111)
+++                    ajoute 3 à la case 2 (111 plus 3 = 114)
.                      imprime le caractère 'r' (114)
------                 enlève 6 à la case 2 (114 moins 6 = 108)
.                      imprime le caractère 'l'  (108)
--------               enlève 8 à la case 2 (108 moins 8 = 100)
.                      imprime le caractère 'd'  (100)
>                      repart à la case 3
+                      ajoute 1 à la case 3 (32 plus 1 = 33)
.                      imprime le caractère '!' (33)
>                      va à la case 4
.                      imprime le caractère '\n'(nouvelle ligne) (10)