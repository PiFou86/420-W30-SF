using System;
using System.Collections.Generic;

namespace POOII_Module07_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Voiture> voitures = new List<Voiture>()
            {
                new Voiture(),
                new Voiture(),
                new Voiture(),
            };

            List<Personne> personnes = new List<Personne>()
            {
                new Personne(),
                new Personne(),
                new Personne(),
            };

            voitures.ForEach(v => Console.Out.WriteLine(v.Identifiant));
            personnes.ForEach(v => Console.Out.WriteLine(v.Identifiant));


            List<VoitureV2> voituresv2 = new List<VoitureV2>()
            {
                new VoitureV2(),
                new VoitureV2(),
                new VoitureV2(),
            };

            List<PersonneV2> personnesv2 = new List<PersonneV2>()
            {
                new PersonneV2(),
                new PersonneV2(),
                new PersonneV2(),
            };

            voituresv2.ForEach(v => Console.Out.WriteLine(v.Identifiant));
            personnesv2.ForEach(v => Console.Out.WriteLine(v.Identifiant));
        }
    }
}
