namespace Version2;

public class Lait : Liquide
{
    public override decimal Volume { get; protected set; }

    public override string Nom => "Lait";

    public Lait(decimal p_volume)
    {
        if (p_volume < 0) {
            throw new ArgumentOutOfRangeException(nameof(p_volume));
        }

        this.Volume = p_volume;
    }
}