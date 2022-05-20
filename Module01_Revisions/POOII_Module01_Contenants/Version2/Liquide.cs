namespace Version2;

public abstract class Liquide : ILiquide
{
    public abstract decimal Volume { get; protected set; }

    public abstract string Nom { get; }

    public void DiminuerVolume(decimal p_pourcentage)
    {
        if (p_pourcentage < 0m || p_pourcentage > 100m) {
            throw new ArgumentOutOfRangeException(nameof(p_pourcentage));
        }

        this.Volume *= 1 - p_pourcentage;
    }

    public override string ToString()
    {
        return $"{this.Nom} : {this.Volume}";
    }
}