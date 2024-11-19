using POOII_M01_E02_DI_Interfaces;

namespace POOII_M01_E02_DI_Journaux
{
    public class FichierJournal : IJournal
    {
        private string _nomFichier = "journal.txt";
        public void Avertissement(string message)
        {
            using (StreamWriter fichier = new StreamWriter(_nomFichier, true))
            {
                fichier.WriteLine($"{DateTime.Now.ToString("u")} Avertissement {message}");
            }
        }

        public void Erreur(string message)
        {
            using (StreamWriter fichier = new StreamWriter(_nomFichier, true))
            {
                fichier.WriteLine($"{DateTime.Now.ToString("u")} Erreur {message}");
            }
        }

        public void Information(string message)
        {
            using (StreamWriter fichier = new StreamWriter(_nomFichier, true))
            {
                fichier.WriteLine($"{DateTime.Now.ToString("u")} Information {message}");
            }
        }
    }
}
