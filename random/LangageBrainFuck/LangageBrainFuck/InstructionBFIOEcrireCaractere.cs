namespace LangageBrainFuck
{
    public class InstructionBFIOEcrireCaractere : InstructionBFIO
    {
        public override IInstruction Executer(IMemoireTravail p_memoireTravail)
        {
            if (p_memoireTravail is null)
            {
                throw new System.ArgumentNullException(nameof(p_memoireTravail));
            }

            System.Console.Out.Write((char)p_memoireTravail.ValeurCourante);

            return base.Executer(p_memoireTravail);
        }
    }
}