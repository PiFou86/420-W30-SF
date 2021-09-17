using POOII_Module12_PreparationCours.Exemple1;
using POOII_Module12_PreparationCours.Exemple2;
using System;
using System.Collections.Generic;

namespace POOII_Module12_PreparationCours
{
    class Program
    {
        static void Main(string[] args)
        {
            Exemple1();
            Example2();
        }

        private static void Example2()
        {
            // Segment -> Rectangle -> Ellipse
            IDessinForme dfSansSentinelle = new DessinerFormeEllipse();
            dfSansSentinelle = new DessinerFormeRectangle() { Suivant = dfSansSentinelle };
            dfSansSentinelle = new DessinerFormeSegment() { Suivant = dfSansSentinelle };

            // Segment -> Rectangle -> Ellipse -> Sentinelle
            IDessinForme dfAvecSentinelle = new DessinerFormeSentinelle();
            dfAvecSentinelle = new DessinerFormeEllipse() { Suivant = dfAvecSentinelle };
            dfAvecSentinelle = new DessinerFormeRectangle() { Suivant = dfAvecSentinelle };
            dfAvecSentinelle = new DessinerFormeSegment() { Suivant = dfAvecSentinelle };

            List<IFormeGeometrique> formes = new List<IFormeGeometrique>()
            {
                new Ellipse(),
                new Rectangle(),
                new Segment(),
                new Triangle()
            };

            Console.Out.WriteLine("Chaine sans sentinnelle : ");
            formes.ForEach((f) =>
            {
                dfSansSentinelle.Dessiner(f);
            });

            Console.Out.WriteLine();
            Console.Out.WriteLine("Chaine avec sentinnelle : ");
            formes.ForEach((f) =>
            {
                try
                {
                    dfAvecSentinelle.Dessiner(f);
                }
                catch (Exception ex)
                {
                    ConsoleColor backColor = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Error.WriteLine(ex.Message);

                    Console.BackgroundColor = backColor;
                }
            });
        }

        private static void Exemple1()
        {
            // tcc1 : MetteEnMajuscules -> SupprimerDiacritics -> AjouterPrefixeSuffixe
            ITraitementChaineCaracteres tcc1 = new TraitementChaineCaracteresAjouterPrefixeSuffixe("<p>", "</p>");
            tcc1 = new TraitementChaineCaracteresSupprimerDiacritiques() { Suivant = tcc1 };
            tcc1 = new TraitementChaineCaracteresMettreEnMajuscules() { Suivant = tcc1 };

            // tcc2 : AjouterPrefixeSuffixe -> SupprimerDiacritics
            ITraitementChaineCaracteres tcc2 = new TraitementChaineCaracteresSupprimerDiacritiques();
            tcc2 = new TraitementChaineCaracteresAjouterPrefixeSuffixe("<p>", "</p>") { Suivant = tcc2 };

            List<string> chaines = new List<string>()
            {
                "éèàçÉÈÀÇ",
                "La vanité, encore qu'elle fleurisse, ne graine pas.",
                "Celui qui a passé le gué sait combien la rivière est profonde."
            };

            chaines.ForEach(s => Console.Out.WriteLine($"{s} :{Environment.NewLine} - tcc1 : {tcc1.TraiterChaineCaracteres(s)}{Environment.NewLine} - tcc2 : {tcc2.TraiterChaineCaracteres(s)}"));
        }
    }
}
