namespace LangageBrainFuck
{
    public interface IMemoireTravail
    {
        public byte[] Dump();

        public void IncrementerPositionIndex();
        public void DecrementerPositionIndex();

        public void IncrementerValeur();
        public void DecrementerValeur();

        public byte ValeurCourante { get; set; }
        public int PositionIndex { get; }
    }
}