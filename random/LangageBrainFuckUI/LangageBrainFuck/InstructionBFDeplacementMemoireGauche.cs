namespace LangageBrainFuck
{
    public class InstructionBFDeplacementMemoireGauche : InstructionBFDeplacementMemoire
    {
        public override IInstruction Executer(IMemoireTravail p_memoireTravail)
        {
            if (p_memoireTravail is null)
            {
                throw new System.ArgumentNullException(nameof(p_memoireTravail));
            }

            p_memoireTravail.DecrementerPositionIndex();

            return base.Executer(p_memoireTravail);
        }
    }
}