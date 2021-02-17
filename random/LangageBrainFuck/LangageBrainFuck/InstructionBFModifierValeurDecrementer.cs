namespace LangageBrainFuck
{
    internal class InstructionBFModifierValeurDecrementer : InstructionBFModifierValeur
    {
        public override IInstruction Executer(IMemoireTravail p_memoireTravail)
        {
            if (p_memoireTravail is null)
            {
                throw new System.ArgumentNullException(nameof(p_memoireTravail));
            }

            p_memoireTravail.DecrementerValeur();

            return base.Executer(p_memoireTravail);
        }
    }
}