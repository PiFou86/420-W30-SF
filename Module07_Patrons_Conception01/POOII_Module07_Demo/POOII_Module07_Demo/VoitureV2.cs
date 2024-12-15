namespace POOII_Module07_Demo;

public class VoitureV2
{
    public int Identifiant { get; set; }

    public VoitureV2()
    {
        this.Identifiant = Singleton<GenerateurIdentifiant>.Instance.GenererIdentifiant();
    }
}
