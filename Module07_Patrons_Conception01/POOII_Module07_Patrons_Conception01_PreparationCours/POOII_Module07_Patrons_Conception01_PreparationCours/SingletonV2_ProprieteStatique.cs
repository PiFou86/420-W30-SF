namespace POOII_Module07_Patrons_Conception01_PreparationCours;

public class SingletonV2_ProprieteStatique
{
    private static SingletonV2_ProprieteStatique _instance;

    public static SingletonV2_ProprieteStatique Instance
    {
        get
        {
            if (_instance is null)
            {
                _instance = new SingletonV2_ProprieteStatique();
            }

            return _instance;
        }
    }

    public string ExempleMehodeDeVotreInstanceUnique()
    {
        return "Je suis une instance unique !";
    }
}
