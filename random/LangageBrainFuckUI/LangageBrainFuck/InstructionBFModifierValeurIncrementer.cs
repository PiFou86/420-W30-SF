namespace LangageBrainFuck
{
    public class InstructionBFModifierValeurIncrementer : InstructionBFModifierValeur
    {
        public override IInstruction Executer(IMemoireTravail p_memoireTravail)
        {
            if (p_memoireTravail is null)
            {
                throw new System.ArgumentNullException(nameof(p_memoireTravail));
            }

            p_memoireTravail.IncrementerValeur();

            return base.Executer(p_memoireTravail);
        }
    }
}