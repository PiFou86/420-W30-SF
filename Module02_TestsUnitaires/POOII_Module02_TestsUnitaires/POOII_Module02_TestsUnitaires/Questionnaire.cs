using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POOII_Module02_TestsUnitaires
{
    public class Questionnaire
    {
        public List<IQuestion> Questions { get; private set; }
        public int TotalPoints
        {
            get
            {
                return this.Questions.Sum(q => q.NombrePointsTotal);
            }
        }
        public int Score { get; private set; }

        public Questionnaire(List<IQuestion> p_listeQuestions)
        {
            if (p_listeQuestions == null)
            {
                throw new ArgumentNullException(nameof(p_listeQuestions));
            }
            if (p_listeQuestions.Count == 0)
            {
                throw new ArgumentException("La liste de questions ne doit pas être vide", nameof(p_listeQuestions));
            }

            this.Questions = new List<IQuestion>(p_listeQuestions);
        }

        public void DemarrerQuestionnaire()
        {
            this.PoserQuestions();
            this.CorrigerQuestions();
            this.AfficherScrore();
        }

        public void AfficherScore()
        {
            throw new NotImplementedException();
        }

        public void CorrigerQuestions()
        {
            int totalPoints = 0;
            foreach (IQuestion question in this.Questions)
            {
                totalPoints += question.CorrigerReponse();
            }

            this.Score = totalPoints;
        }

        public void PoserQuestions()
        {
            foreach (IQuestion question in this.Questions)
            {
                question.PoserQuestion();
            }
        }
    }
}
