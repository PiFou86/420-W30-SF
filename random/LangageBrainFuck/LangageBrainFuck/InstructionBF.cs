namespace LangageBrainFuck
{
    public abstract class InstructionBF : IInstruction
    {
        public IInstruction InstructionSuivante { get; set; }
        public InformationInstruction InformationInstruction { get; set; }

        public virtual IInstruction Executer(IMemoireTravail p_memoireTravail)
        {
            return this.InstructionSuivante;
        }
    }
}