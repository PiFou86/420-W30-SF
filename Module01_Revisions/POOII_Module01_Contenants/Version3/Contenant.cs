using System.Text;

namespace Version3;

public class Contenant : IContenant
{
    private List<ILiquide> m_liquides;
    public decimal VolumeContenant { get; }
    public string Nom { get; }
    public decimal VolumeMaximum { get => this.VolumeContenant * 0.95m; }
    public decimal VolumeLiquides { get => this.m_liquides.Sum(l => l.Volume); }

    public Contenant(string p_nom,
                     decimal p_volume)
    {
        if (String.IsNullOrWhiteSpace(p_nom)) {
            throw new ArgumentOutOfRangeException(nameof(p_nom));
        }

        if (p_volume <= 0) {
            throw new ArgumentOutOfRangeException(nameof(p_volume));
        }

        this.m_liquides = new List<ILiquide>();
        this.VolumeContenant = p_volume;
        this.Nom = p_nom;
    }

    public void AjouterLiquide(ILiquide p_liquide)
    {
        if (p_liquide is null)
        {
            throw new ArgumentNullException(nameof(p_liquide));
        }

        if (p_liquide.Volume < 0 || this.VolumeLiquides + p_liquide.Volume > this.VolumeMaximum)
        {
            throw new ArgumentOutOfRangeException(nameof(p_liquide), "Le volume du liquide est négatif ou dépasse la capacité du contenant");
        }

        this.m_liquides.Add(p_liquide);
    }

    public sealed override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Contenant : {this.Nom}(VolumeContenant : {this.VolumeContenant}, VolumeMaximum : {this.VolumeMaximum}, VolumeLiquides : {this.VolumeLiquides})");
        sb.AppendJoin(System.Environment.NewLine, this.m_liquides);

        return sb.ToString();
    }

    public void Verser(decimal p_quantiteMl)
    {
        if (p_quantiteMl < 0) {
            throw new ArgumentOutOfRangeException(nameof(p_quantiteMl), "La quantité en ml doit être positive");
        }

        if (p_quantiteMl > this.VolumeLiquides) {
            throw new ArgumentOutOfRangeException(nameof(p_quantiteMl), "La quantité en ml ne doit pas être supérieure au volume du mélange des liquides");
        }

        decimal pourcentage = p_quantiteMl / this.VolumeLiquides;
        this.m_liquides.ForEach(l => l.DiminuerVolume(pourcentage));
    }
}
