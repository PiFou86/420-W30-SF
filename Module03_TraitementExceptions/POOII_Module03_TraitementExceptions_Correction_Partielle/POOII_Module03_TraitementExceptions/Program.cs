using POOII_Module03_TraitementExceptions.Matrices;
using System;
using System.IO;
using System.Text;

namespace POOII_Module03_TraitementExceptions
{
    class Program
    {
        static void Main(string[] args)
        {


            //DemoVoiture();

            //LectureFichier();

            // Exemple tableau 2D
            //double[,] tableau2D = new double[3, 4];
            //Console.Out.WriteLine($"Nombre de dimension : {tableau2D.Rank}");
            //Console.Out.WriteLine($"Capacité dimension 1 : {tableau2D.GetLength(0)}");
            //Console.Out.WriteLine($"Capacité dimension 2 : {tableau2D.GetLength(1)}");
            //for (int indiceLigne = 0; indiceLigne < tableau2D.GetLength(0); indiceLigne++)
            //{
            //    Console.Out.Write(tableau2D[indiceLigne, 0]);
            //    for (int indiceColonne = 1; indiceColonne < tableau2D.GetLength(1); indiceColonne++)
            //    {
            //        Console.Out.Write($", {tableau2D[indiceLigne, indiceColonne]}");
            //    }
            //    Console.Out.WriteLine();
            //}

            DemoMatrices();

            try
            {
                DemoTry();
            }
            catch (ErreurFonctionnelleException efex)
            {
                //Logger.Write(efex);
                Console.Out.WriteLine($"Code fonctionnel : {efex.CodeErreur} {efex.Message}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Erreur inconnue");
            }

        }

        public static void LectureFichier()
        {
            string nomFichier = Console.In.ReadLine();
            using (StreamReader sr = new StreamReader(nomFichier))
            {
                // Tant que nous ne sommes pas arrivés à la fin du fichier
                while (!sr.EndOfStream)
                {
                    // Lire une ligne
                    string ligneActuelleDuFichier = sr.ReadLine();
                    // à compléter...
                }
            }
        }

        public static void DemoTry()
        {
            try
            {
                // Bloc de code qui peut lever une exception
                using (StreamReader sr = new StreamReader("Un nom de fichier.txt", Encoding.UTF8))
                {
                    // ...
                }
            }
            catch (FileNotFoundException ex)
            {
                // Fichier non trouvé
                throw new ErreurFonctionnelleException("E231", "Le fichier n'est pas trouvé", ex);
            }
            catch (Exception ex)
            {
                // Autres erreurs ?

                throw; // Relancer la même exception sans perdre la StackTrace
            }
            finally
            {
                // Libération de ressources : fermeture de fichiers et de connexions, etc.
            }
        }

        public static void DemoVoiture()
        {
            int choixMenu = 0;
            Voiture voiture = new Voiture();
            do
            {
                Console.Out.WriteLine("1. Démarrer");
                Console.Out.WriteLine("2. Arrêter");
                Console.Out.WriteLine("9. Quitter");

                choixMenu = Console.In.ReadInt();

                try
                {
                    switch (choixMenu)
                    {
                        case 1:
                            voiture.Demarrer();
                            break;
                        case 2:
                            voiture.Arreter();
                            break;
                        case 9:
                            break;
                        default:
                            throw new InvalidOperationException("Option incorrecte");
                    }
                }
                catch (VoitureDejaDemarreeException ex)
                {
                    Console.Error.WriteLine("La voiture est déjà démarrée");
                }
                catch (VoitureDejaArreteeException ex)
                {
                    Console.Error.WriteLine("La voiture est déjà arrêtée");
                }
                catch (InvalidOperationException ex)
                {
                    Console.Error.WriteLine($"Opération invalide : {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine($"Erreur non prévue : {ex.Message}");
                }
            } while (choixMenu != 9);
        }

        public static void DemoMatrices()
        {
            Console.Out.WriteLine(Matrices.Matrice2D.Identite(5) * (float)Math.PI * 100);

            Matrice2D operande1 = new Matrice2D(new float[,]
            {
                {5, 1},
                {2, 3},
                {3, 4},
            });
            Matrice2D operande2 = new Matrice2D(new float[,]
            {
                {1, 2, 0},
                {4, 3, -1},
            });
            Matrice2D resultatAttendu = new Matrice2D(new float[,]
            {
                {9, 13, -1},
                {14, 13, -3},
                {19, 18, -4},
            });
            Console.Out.WriteLine(operande1);
            Console.Out.WriteLine('*');
            Console.Out.WriteLine(operande2);
            Console.Out.WriteLine('=');
            Console.Out.WriteLine(operande1 * operande2);
            Console.Out.WriteLine();
            Console.Out.WriteLine();

            Console.Out.WriteLine(operande2);
            Console.Out.WriteLine('*');
            Console.Out.WriteLine(operande1);
            Console.Out.WriteLine('=');
            Console.Out.WriteLine(operande2 * operande1);
        }
    }
}
