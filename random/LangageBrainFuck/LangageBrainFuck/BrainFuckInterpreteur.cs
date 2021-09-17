using System.Collections.Generic;

namespace LangageBrainFuck
{
    public class BrainFuckInterpreteur : IInterpreteur
    {
        public IInstruction Instructions { get; private set; }
        public BFMemoireTravail MemoireTravail { get; private set; }

        public BrainFuckInterpreteur(int p_tailleMemoire)
        {
            this.Instructions = null;
            this.MemoireTravail = new BFMemoireTravail(p_tailleMemoire);
        }

        public void ChargerProgramme(string codeDuProgramme)
        {
            if (codeDuProgramme is null)
            {
                throw new System.ArgumentOutOfRangeException(nameof(codeDuProgramme));
            }

            IInstruction instructionCourante = new InstructionBFDebutProgramme();
            this.Instructions = instructionCourante;
            Stack<InstructionBFBoucleDebut> debutBoucle = new Stack<InstructionBFBoucleDebut>();
            for (int indexInstruction = 0; indexInstruction < codeDuProgramme.Length; ++indexInstruction)
            {
                char instruction = codeDuProgramme[indexInstruction];
                IInstruction nouvelleInstruction = null;

                switch (instruction)
                {
                    case '<':
                        nouvelleInstruction = new InstructionBFDeplacementMemoireGauche();
                        break;
                    case '>':
                        nouvelleInstruction = new InstructionBFDeplacementMemoireDroite();
                        break;

                    case '+':
                        nouvelleInstruction = new InstructionBFModifierValeurIncrementer();
                        break;
                    case '-':
                        nouvelleInstruction = new InstructionBFModifierValeurDecrementer();
                        break;

                    case '.':
                        nouvelleInstruction = new InstructionBFIOEcrireCaractere();
                        break;
                    case ',':
                        nouvelleInstruction = new InstructionBFIOLireCaractere();
                        break;

                    case '[':
                        nouvelleInstruction = new InstructionBFBoucleDebut();
                        debutBoucle.Push((InstructionBFBoucleDebut)nouvelleInstruction);
                        break;
                    case ']':
                        if (debutBoucle.Count == 0)
                        {
                            this.Instructions = null;
                            throw new SyntaxErrorException();
                        }
                        nouvelleInstruction = new InstructionBFBoucleFin() { DebutBoucle = debutBoucle.Pop() };
                        break;

                    default:
                        break;
                }

                if (nouvelleInstruction != null)
                {
                    nouvelleInstruction.InformationInstruction = new InformationInstruction()
                    {
                        Instruction = instruction.ToString(),
                        Longueur = 1,
                        NumeroCaractere = indexInstruction + 1
                    };
                    instructionCourante.InstructionSuivante = nouvelleInstruction;
                    instructionCourante = nouvelleInstruction;
                }
            }

            instructionCourante.InstructionSuivante = new InstructionBFFinProgramme();

            if (debutBoucle.Count != 0)
            {
                this.Instructions = null;
                throw new SyntaxErrorException();
            }
        }

        public void Executer()
        {
            IInstruction instructionCourante = this.Instructions;
            this.MemoireTravail.Initialiser();
            while (instructionCourante != null)
            {
                instructionCourante = instructionCourante.Executer(this.MemoireTravail);
            }
        }
    }
}