using POOII_M01_E02_DI_Interfaces;

namespace POOII_M01_E02_DI_Journaux
{
    public class ConsoleJournal : IJournal
    {
        public void Avertissement(string message)
        {
            Console.Out.WriteLine($"Avertissement {message}");
        }

        public void Erreur(string message)
        {
            Console.Error.WriteLine($"Erreur {message}");
        }

        public void Information(string message)
        {
            Console.Out.WriteLine($"Information {message}");
        }
    }
}
