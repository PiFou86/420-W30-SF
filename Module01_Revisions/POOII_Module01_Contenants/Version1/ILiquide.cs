namespace Version1;

public interface ILiquide
{
    decimal Volume { get; }
    string Nom { get; }

    void DiminuerVolume(decimal p_pourcentage);
}
