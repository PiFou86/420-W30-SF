namespace LangageBrainFuck
{
    public interface IInstruction
    {
        public IInstruction InstructionSuivante { get; set; }
        public InformationInstruction InformationInstruction { get; set; }
        public IInstruction Executer(IMemoireTravail p_memoireTravail);
    }
}