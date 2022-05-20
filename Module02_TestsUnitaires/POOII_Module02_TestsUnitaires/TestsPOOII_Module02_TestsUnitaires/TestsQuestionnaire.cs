using FluentAssertions;
using Moq;
using POOII_Module02_TestsUnitaires;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestsPOOII_Module02_TestsUnitaires
{
    public class TestsQuestionnaire
    {
        [Fact]
        public void Ctor_ListeNulle_Exception()
        {
            // Arranger
            List<IQuestion> questions = null;
            string nomParametreEnErreur = "p_listeQuestions";

            // Agir && Assert
            ArgumentNullException ae = Assert.Throws<ArgumentNullException>(() =>
            {
                Questionnaire questionnaire = new Questionnaire(questions);
            });
            Assert.Equal(nomParametreEnErreur, ae.ParamName);
        }

        [Fact]
        public void Ctor_ListeNulleVFluentAssertion_Exception()
        {
            // Arranger
            List<IQuestion> questions = null;
            string nomParametreEnErreur = "p_listeQuestions";
            Action act = () => new Questionnaire(questions);

            // Agir && Assert
            act.Should().Throw<ArgumentNullException>()
                .And.ParamName.Should().Be(nomParametreEnErreur);
        }

        [Fact]
        public void CorrigerQuestions_QuestionnaireEffectueFluentAssertion_SommePoints()
        {
            // Arranger
            Mock<IQuestion> mockQuestion1Point = new Mock<IQuestion>();
            mockQuestion1Point.Setup(q => q.CorrigerReponse()).Returns(1);
            Mock<IQuestion> mockQuestion2Point = new Mock<IQuestion>();
            mockQuestion2Point.Setup(q => q.CorrigerReponse()).Returns(2);
            Mock<IQuestion> mockQuestion3Point = new Mock<IQuestion>();
            mockQuestion3Point.Setup(q => q.CorrigerReponse()).Returns(4);

            List<IQuestion> questions = new List<IQuestion>()
            {
                mockQuestion1Point.Object,
                mockQuestion2Point.Object,
                mockQuestion3Point.Object
            };
            Questionnaire questionnaire = new Questionnaire(questions);
            int scoreCalculeAttendu = 7;

            // Agir
            questionnaire.CorrigerQuestions();

            // Assert
            questionnaire.Score.Should().Be(scoreCalculeAttendu);
            mockQuestion1Point.Verify(q => q.CorrigerReponse(), Times.Once);
            mockQuestion1Point.VerifyNoOtherCalls();

            mockQuestion2Point.Verify(q => q.CorrigerReponse(), Times.Once);
            mockQuestion2Point.VerifyNoOtherCalls();

            mockQuestion3Point.Verify(q => q.CorrigerReponse(), Times.Once);
            mockQuestion3Point.VerifyNoOtherCalls();

        }

        [Fact]
        public void Ctor_ListeVide_Exception()
        {
            // Arranger
            List<IQuestion> questions = new List<IQuestion>();
            string nomParametreEnErreurAttendu = "p_listeQuestions";
            string messageAttendu = "La liste de questions ne doit pas  tre vide (Parameter 'p_listeQuestions')";

            // Agir && Assert
            ArgumentException ae = Assert.Throws<ArgumentException>(() =>
            {
                Questionnaire questionnaire = new Questionnaire(questions);
            });
            Assert.Equal(nomParametreEnErreurAttendu, ae.ParamName);
            Assert.Equal(messageAttendu, ae.Message);
        }

        [Fact]
        public void TotalPoints_ListeAvecQuestions_SommePoints()
        {
            // Arranger
            Mock<IQuestion> mockQuestion1Point = new Mock<IQuestion>();
            mockQuestion1Point.SetupGet(q => q.NombrePointsTotal).Returns(1);
            Mock<IQuestion> mockQuestion2Point = new Mock<IQuestion>();
            mockQuestion2Point.SetupGet(q => q.NombrePointsTotal).Returns(2);
            Mock<IQuestion> mockQuestion3Point = new Mock<IQuestion>();
            mockQuestion3Point.SetupGet(q => q.NombrePointsTotal).Returns(4);

            List<IQuestion> questions = new List<IQuestion>()
            {
                mockQuestion1Point.Object,
                mockQuestion2Point.Object,
                mockQuestion3Point.Object
            };
            Questionnaire questionnaire = new Questionnaire(questions);
            int totalPointsAttendu = 7;

            // Agir
            int totalPointsCalcule = questionnaire.TotalPoints;

            // Assert
            Assert.Equal(totalPointsAttendu, totalPointsCalcule);
            mockQuestion1Point.VerifyGet(q => q.NombrePointsTotal, Times.Once);
            mockQuestion2Point.VerifyGet(q => q.NombrePointsTotal, Times.Once);
            mockQuestion3Point.VerifyGet(q => q.NombrePointsTotal, Times.Once);

            totalPointsCalcule.Should().Be(totalPointsAttendu);
        }

        [Fact]
        public void Score_QuestionnaireNonDemarre_Score0()
        {
            // Arranger
            Mock<IQuestion> mockQuestion1Point = new Mock<IQuestion>();
            Mock<IQuestion> mockQuestion2Point = new Mock<IQuestion>();
            Mock<IQuestion> mockQuestion3Point = new Mock<IQuestion>();

            List<IQuestion> questions = new List<IQuestion>()
            {
                mockQuestion1Point.Object,
                mockQuestion2Point.Object,
                mockQuestion3Point.Object
            };
            Questionnaire questionnaire = new Questionnaire(questions);
            int scoreCalculeAttendu = 0;

            // Agir
            int scoreCalcule = questionnaire.Score;

            // Assert
            Assert.Equal(scoreCalculeAttendu, scoreCalcule);
            mockQuestion1Point.VerifyNoOtherCalls();
            mockQuestion2Point.VerifyNoOtherCalls();
            mockQuestion3Point.VerifyNoOtherCalls();
        }

        [Fact]
        public void CorrigerQuestions_QuestionnaireEffectue_SommeScore()
        {
            // Arranger
            Mock<IQuestion> mockQuestion1Point = new Mock<IQuestion>();
            mockQuestion1Point.Setup(q => q.CorrigerReponse()).Returns(1);
            Mock<IQuestion> mockQuestion2Point = new Mock<IQuestion>();
            mockQuestion2Point.Setup(q => q.CorrigerReponse()).Returns(2);
            Mock<IQuestion> mockQuestion3Point = new Mock<IQuestion>();
            mockQuestion3Point.Setup(q => q.CorrigerReponse()).Returns(4);

            List<IQuestion> questions = new List<IQuestion>()
            {
                mockQuestion1Point.Object,
                mockQuestion2Point.Object,
                mockQuestion3Point.Object
            };
            Questionnaire questionnaire = new Questionnaire(questions);
            int scoreCalculeAttendu = 7;

            // Agir
            questionnaire.CorrigerQuestions();

            // Assert
            Assert.Equal(scoreCalculeAttendu, questionnaire.Score);
            mockQuestion1Point.Verify(q => q.CorrigerReponse(), Times.Once);
            mockQuestion1Point.VerifyNoOtherCalls();

            mockQuestion2Point.Verify(q => q.CorrigerReponse(), Times.Once);
            mockQuestion2Point.VerifyNoOtherCalls();

            mockQuestion3Point.Verify(q => q.CorrigerReponse(), Times.Once);
            mockQuestion3Point.VerifyNoOtherCalls();
        }
    }
}
