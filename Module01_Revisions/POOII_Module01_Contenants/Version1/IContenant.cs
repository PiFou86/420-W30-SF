namespace Version1;

public interface IContenant
{
    decimal VolumeContenant { get; }
    decimal VolumeMaximum { get; }
    decimal VolumeLiquides { get; }
    string Nom { get; }
    void AjouterLiquide(ILiquide p_liquide);
    void Verser(decimal p_quantiteMl);
}
