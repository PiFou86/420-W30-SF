# Module 02 - Tests unitaires

## Exercice 1 - Questionnaire

Reprendre le code présent dans le même répertoire que le fichier d'exercices.

1. Créez un nouveau projet de tests XUnit et appelez le "Tests_Perso_POOII_Module02_TestsUnitaires" et liez le projet à tester
2. Installez les paquets NuGet "Moq" et "Fluent assertion"
3. Testez les méthodes et propriétés, en validant le nombre d'appels et le non appel des méthodes/propriétés non essentielles :
   1. CorrigerQuestions
   2. TotalPoints
   3. Score
   4. PoserQuestions
4. Modifiez le code de PoserQuestions afin que celui-ci appelle plusieurs fois la méthode PoserQuestion des questions. Validez que certains de vos tests échoues.
5. Modifiez le code de PoserQuestions afin que celui-ci appelle d'autres méthodes et propriétés des questions. Validez que certains de vos tests échoues.
