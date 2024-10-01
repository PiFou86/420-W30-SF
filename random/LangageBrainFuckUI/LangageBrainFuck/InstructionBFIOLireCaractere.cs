namespace LangageBrainFuck;

public class InstructionBFIOLireCaractere : InstructionBFIO
{
    public override IInstruction Executer(IMemoireTravail p_memoireTravail)
    {
        if (p_memoireTravail is null)
        {
            throw new System.ArgumentNullException(nameof(p_memoireTravail));
        }

        p_memoireTravail.ValeurCourante = (byte)System.Console.In.Read();

        return base.Executer(p_memoireTravail);
    }
}
