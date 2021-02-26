using System;
using System.Collections.Generic;

namespace LangageBrainFuck
{
    public class BrainFuckInterpreteur : IInterpreteur
    {
        public IInstruction Instructions { get; private set; }
        public BFMemoireTravail MemoireTravail { get; private set; }
        public bool CodeTermine => this.m_instructionCourante is null;

        private IInstruction m_instructionCourante = null;
        private List<IObserver<InterpreteurEvent>> m_obeservateurs = new List<IObserver<InterpreteurEvent>>();
        public bool EstDebogue { get; internal set; }


        public BrainFuckInterpreteur(int p_tailleMemoire)
        {
            this.Instructions = null;
            this.MemoireTravail = new BFMemoireTravail(p_tailleMemoire);
        }

        public void ChargerProgramme(string codeDuProgramme)
        {
            if (codeDuProgramme is null)
            {
                throw new System.ArgumentOutOfRangeException(nameof(codeDuProgramme));
            }

            IInstruction instructionCourante = new InstructionBFDebutProgramme();
            this.Instructions = instructionCourante;
            Stack<InstructionBFBoucleDebut> debutBoucle = new Stack<InstructionBFBoucleDebut>();
            for (int indexInstruction = 0; indexInstruction < codeDuProgramme.Length; ++indexInstruction)
            {
                char instruction = codeDuProgramme[indexInstruction];
                IInstruction nouvelleInstruction = null;

                switch (instruction)
                {
                    case '<':
                        nouvelleInstruction = new InstructionBFDeplacementMemoireGauche();
                        break;
                    case '>':
                        nouvelleInstruction = new InstructionBFDeplacementMemoireDroite();
                        break;

                    case '+':
                        nouvelleInstruction = new InstructionBFModifierValeurIncrementer();
                        break;
                    case '-':
                        nouvelleInstruction = new InstructionBFModifierValeurDecrementer();
                        break;

                    case '.':
                        nouvelleInstruction = new InstructionBFIOEcrireCaractere();
                        break;
                    case ',':
                        nouvelleInstruction = new InstructionBFIOLireCaractere();
                        break;

                    case '[':
                        nouvelleInstruction = new InstructionBFBoucleDebut();
                        debutBoucle.Push((InstructionBFBoucleDebut)nouvelleInstruction);
                        break;
                    case ']':
                        if (debutBoucle.Count == 0)
                        {
                            this.Instructions = null;
                            throw new SyntaxErrorException();
                        }
                        nouvelleInstruction = new InstructionBFBoucleFin() { DebutBoucle = debutBoucle.Pop() };
                        break;

                    default:
                        break;
                }

                if (nouvelleInstruction != null)
                {
                    nouvelleInstruction.InformationInstruction = new InformationInstruction()
                    {
                        Instruction = instruction.ToString(),
                        Longueur = 1,
                        NumeroCaractere = indexInstruction + 1
                    };
                    instructionCourante.InstructionSuivante = nouvelleInstruction;
                    instructionCourante = nouvelleInstruction;
                }
            }

            instructionCourante.InstructionSuivante = new InstructionBFFinProgramme();

            if (debutBoucle.Count != 0)
            {
                this.Instructions = null;
                throw new SyntaxErrorException();
            }
        }

        public void Executer()
        {
            Reinitialiser(false);
            AvertirDebutProgramme();
            while (!CodeTermine)
            {
                ExecuterUneInstruction(false);
            }
        }

        public void Reinitialiser(bool p_deboguage)
        {
            this.EstDebogue = p_deboguage;
            this.m_instructionCourante = this.Instructions;
            this.MemoireTravail.Initialiser();
            AvertirReinitialisation();
        }

        private void ExecuterUneInstruction(bool p_appelDirect)
        {
            IInstruction instructionExecutee = this.m_instructionCourante;
            this.m_instructionCourante = this.m_instructionCourante.Executer(this.MemoireTravail);
            AvertirExecutionUnPas(instructionExecutee, p_appelDirect);

            if (this.m_instructionCourante is null)
            {
                AvertirFinProgramme();
            }
        }

        public void ExecuterUneInstruction()
        {
            ExecuterUneInstruction(true);
        }

        public IDisposable Subscribe(IObserver<InterpreteurEvent> p_observateurInterpreteur)
        {
            if (p_observateurInterpreteur is null)
            {
                throw new ArgumentNullException(nameof(p_observateurInterpreteur));
            }

            this.m_obeservateurs.Add(p_observateurInterpreteur);

            return new UnsubscribeInterpreteur(this.m_obeservateurs, p_observateurInterpreteur);
        }

        private void AvertirReinitialisation()
        {
            this.m_obeservateurs.ForEach(obs => obs.OnNext(
                new InterpreteurEvent()
                {
                    InstructionExecutee = null,
                    InstructionSuivante = this.m_instructionCourante.InformationInstruction,
                    MemoryDump = this.MemoireTravail.Dump(),
                    Type = InterpreteurEventType.INITIALISATION,
                    EstDebogue = EstDebogue,
                    PositionIndexMemoire = this.MemoireTravail.PositionIndex
                }
            ));
        }

        private void AvertirDebutProgramme()
        {
            this.m_obeservateurs.ForEach(obs => obs.OnNext(
                new InterpreteurEvent()
                {
                    InstructionExecutee = null,
                    InstructionSuivante = this.m_instructionCourante.InformationInstruction,
                    MemoryDump = this.MemoireTravail.Dump(),
                    Type = InterpreteurEventType.DEBUT_EXECUTION,
                    EstDebogue = EstDebogue,
                    PositionIndexMemoire = this.MemoireTravail.PositionIndex
                }
            ));
        }
        private void AvertirExecutionUnPas(IInstruction p_instructionExecutee, bool p_appelDirect)
        {
            this.m_obeservateurs.ForEach(obs => obs.OnNext(
                new InterpreteurEvent()
                {
                    InstructionExecutee = p_instructionExecutee.InformationInstruction,
                    InstructionSuivante = this.m_instructionCourante?.InformationInstruction,
                    MemoryDump = this.MemoireTravail.Dump(),
                    Type = InterpreteurEventType.EN_COURS_EXECUTION,
                    EstDebogue = EstDebogue,
                    PositionIndexMemoire = this.MemoireTravail.PositionIndex
                }
            ));
        }

        private void AvertirFinProgramme()
        {
            this.m_obeservateurs.ForEach(obs => obs.OnNext(
                new InterpreteurEvent()
                {
                    InstructionExecutee = null,
                    InstructionSuivante = null,
                    MemoryDump = this.MemoireTravail.Dump(),
                    Type = InterpreteurEventType.FIN_EXECUTION,
                    EstDebogue = EstDebogue,
                    PositionIndexMemoire = this.MemoireTravail.PositionIndex
                }
            ));
        }
    }
}