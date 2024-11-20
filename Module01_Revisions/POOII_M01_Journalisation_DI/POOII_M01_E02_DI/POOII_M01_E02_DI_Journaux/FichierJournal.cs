using POOII_M01_E02_DI_Interfaces;
using System.Runtime.ExceptionServices;

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

            // Équivalent à (sans gestion des exceptions) :
            //StreamWriter fichier = new StreamWriter(_nomFichier, true);
            //fichier.WriteLine($"{DateTime.Now.ToString("u")} Avertissement {message}");
            //fichier.Close(); // Sera fait par le Dispose mais on peut le faire explicitement pour indiquer qu'on a fini
            //fichier.Dispose();

            // Équivalent à (avec gestion des exceptions (vu plus loin dans le cours)) :
            //StreamWriter fichier = null;
            //try
            //{
            //    fichier = new StreamWriter(_nomFichier, true);
            //    fichier.WriteLine($"{DateTime.Now.ToString("u")} Avertissement {message}");
            //}
            //finally
            //{
            //    if (fichier != null)
            //    {
            //        fichier.Close();
            //        fichier.Dispose();
            //    }
            //}


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
