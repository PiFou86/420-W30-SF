namespace LangageBrainFuck;

public class InstructionBFDeplacementMemoireDroite : InstructionBFDeplacementMemoire
{
    public override IInstruction Executer(IMemoireTravail p_memoireTravail)
    {
        if (p_memoireTravail is null)
        {
            throw new System.ArgumentNullException(nameof(p_memoireTravail));
        }

        p_memoireTravail.IncrementerPositionIndex();

        return base.Executer(p_memoireTravail);
    }
}
