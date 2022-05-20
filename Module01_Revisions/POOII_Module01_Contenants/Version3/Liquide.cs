namespace Version3;

public class Liquide : ILiquide
{
    public decimal Volume { get; private set; }

    public string Nom { get; }

    public void DiminuerVolume(decimal p_pourcentage)
    {
        if (p_pourcentage < 0m || p_pourcentage > 100m)
        {
            throw new ArgumentOutOfRangeException(nameof(p_pourcentage));
        }

        this.Volume *= 1 - p_pourcentage;
    }

    public Liquide(string p_nom, decimal p_volume)
    {
        if (String.IsNullOrWhiteSpace(p_nom))
        {
            throw new ArgumentOutOfRangeException(nameof(p_nom));
        }

        if (p_volume <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(p_volume));
        }

        this.Nom = p_nom;
        this.Volume = p_volume;
    }

    public override string ToString()
    {
        return $"{this.Nom} : {this.Volume}";
    }
}