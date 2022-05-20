namespace Version2;

public class Creme : Liquide
{
    public override decimal Volume { get; protected set; }

    public override string Nom => "Crème";

    public Creme(decimal p_volume)
    {
        if (p_volume < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(p_volume));
        }

        this.Volume = p_volume;
    }
}