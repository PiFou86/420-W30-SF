namespace LangageBrainFuck;

internal class InstructionBFBoucleFin : InstructionBFBoucle
{
    public InstructionBFBoucleDebut DebutBoucle { get; internal set; }

    public override IInstruction Executer(IMemoireTravail p_memoireTravail)
    {
        if (p_memoireTravail is null)
        {
            throw new System.ArgumentNullException(nameof(p_memoireTravail));
        }

        if (p_memoireTravail.ValeurCourante != 0)
        {
            return this.DebutBoucle;
        }

        return base.Executer(p_memoireTravail);
    }
}
