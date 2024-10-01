namespace POOII_Module07_Demo;

public class Voiture
{
    public int Identifiant { get; set; }

    public Voiture()
    {
        this.Identifiant = GenerateurIdentifiantSingleton.Instance.GenererIdentifiant();
    }
}
