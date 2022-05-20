namespace Version3;

public interface IContenant
{
    decimal VolumeContenant { get; }
    decimal VolumeMaximum { get; }
    decimal VolumeLiquides { get; }
    string Nom { get; }
    void Verser(decimal p_quantiteMl);
    void AjouterLiquide(ILiquide p_liquide);
}
