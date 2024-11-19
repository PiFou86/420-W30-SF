using POOII_M01_E02_DI_Interfaces;

namespace POOII_M01_E02_DI_Journaux
{
    public class ConsoleJournalAvecHeure : IJournal
    {

        public void Avertissement(string message)
        {
            Console.Out.WriteLine($"{System.DateTime.Now.ToString("u")} Avertissement {message}");
        }

        public void Erreur(string message)
        {
            Console.Error.WriteLine($"{System.DateTime.Now.ToString("u")} Erreur {message}");
        }

        public void Information(string message)
        {
            Console.Out.WriteLine($"{System.DateTime.Now.ToString("u")} Information {message}");
        }

    }
}
