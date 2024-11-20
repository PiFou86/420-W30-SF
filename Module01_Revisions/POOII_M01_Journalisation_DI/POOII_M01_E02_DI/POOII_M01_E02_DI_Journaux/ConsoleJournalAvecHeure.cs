using POOII_M01_E02_DI_Interfaces;

namespace POOII_M01_E02_DI_Journaux
{
    public class ConsoleJournalAvecHeure : IJournal
    {

        public void Avertissement(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Out.WriteLine($"{System.DateTime.Now.ToString("u")} Avertissement {message}");
            Console.ResetColor();
        }

        public void Erreur(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine($"{System.DateTime.Now.ToString("u")} Erreur {message}");
            Console.ResetColor();
        }

        public void Information(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Out.WriteLine($"{System.DateTime.Now.ToString("u")} Information {message}");
            Console.ResetColor();
        }

    }
}
