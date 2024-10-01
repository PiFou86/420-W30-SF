using System.Collections.Generic;

namespace POOII_Module07_Demo;

public class Personne
{
    public List<Voiture> Voitures { get; set; }
    public int Identifiant { get; set; }

    public Personne()
    {
        this.Identifiant = GenerateurIdentifiantSingleton.Instance.GenererIdentifiant();
        this.Voitures = new List<Voiture>();
    }
}
