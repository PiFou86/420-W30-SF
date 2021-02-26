namespace LangageBrainFuck
{
    public class InterpreteurEvent
    {
        public InterpreteurEventType Type { get; internal set; }
        public byte[] MemoryDump { get; internal set; }
        public InformationInstruction InstructionExecutee { get; internal set; }
        public InformationInstruction InstructionSuivante { get; internal set; }
        public bool EstDebogue { get; internal set; }
        public int PositionIndexMemoire { get; internal set; }
    }
}