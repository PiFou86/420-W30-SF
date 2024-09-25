using System.Collections.Generic;

namespace POOII_Module07_Demo;

public class PersonneV2
{
    public List<VoitureV2> Voitures { get; set; }
    public int Identifiant { get; set; }

    public PersonneV2()
    {
        this.Identifiant = Singleton<GenerateurIdentifiant>.Instance.GenererIdentifiant();
        this.Voitures = new List<VoitureV2>();
    }
}
