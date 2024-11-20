using POOII_M01_E02_DI_Interfaces;

namespace POOII_M01_E02_DI_Journaux
{
    public class ConsoleJournal : IJournal
    {
        public void Avertissement(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Out.WriteLine($"Avertissement {message}");
            Console.ResetColor();
        }

        public void Erreur(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine($"Erreur {message}");
            Console.ResetColor();
        }

        public void Information(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Out.WriteLine($"Information {message}");
            Console.ResetColor();
        }
    }
}
