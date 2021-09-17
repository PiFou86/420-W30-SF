using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module03_TraitementExceptions.Matrices
{
    public class Matrice2D
    {
        const int NOMBRE_ESPACES_AVANT = 1;
        const int NOMBRE_CHIFFRE_APRES_VIRGULE = 2;
        private float[,] m_donnees;

        public int NombreDeLignes => this.m_donnees.GetLength(0);
        public int NombreDeColonnes => this.m_donnees.GetLength(1);

        public Matrice2D(int p_nombreLignes, int p_nombreColonnes)
        {
            if (p_nombreLignes <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(p_nombreLignes));
            }
            if (p_nombreColonnes <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(p_nombreColonnes));
            }

            this.m_donnees = new float[p_nombreLignes, p_nombreColonnes];
        }

        public Matrice2D(float[,] p_valeurs, bool p_copie = true)
        {
            if (p_valeurs == null)
            {
                throw new ArgumentNullException(nameof(p_valeurs));
            }

            if (p_copie)
            {
                this.m_donnees = new float[p_valeurs.GetLength(0), p_valeurs.GetLength(1)];

                for (int indiceLigneCopie = 0; indiceLigneCopie < p_valeurs.GetLength(0); indiceLigneCopie++)
                {
                    for (int indiceColonneCopie = 0; indiceColonneCopie < p_valeurs.GetLength(1); indiceColonneCopie++)
                    {
                        this.m_donnees[indiceLigneCopie, indiceColonneCopie] = p_valeurs[indiceLigneCopie, indiceColonneCopie];
                    }
                }
            }
            else
            {
                this.m_donnees = p_valeurs;
            }
        }

        public float this[int p_ligne, int p_colonne]
        {
            get
            {
                if (p_ligne < 0 || p_ligne >= this.m_donnees.GetLength(0))
                {
                    throw new ArgumentOutOfRangeException(nameof(p_ligne));
                }
                if (p_colonne < 0 || p_colonne >= this.m_donnees.GetLength(1))
                {
                    throw new ArgumentOutOfRangeException(nameof(p_colonne));
                }

                return this.m_donnees[p_ligne, p_colonne];
            }
            set
            {
                if (p_ligne < 0 || p_ligne >= this.m_donnees.GetLength(0))
                {
                    throw new ArgumentOutOfRangeException(nameof(p_ligne));
                }
                if (p_colonne < 0 || p_colonne >= this.m_donnees.GetLength(1))
                {
                    throw new ArgumentOutOfRangeException(nameof(p_colonne));
                }

                this.m_donnees[p_ligne, p_colonne] = value;
            }
        }


        public static Matrice2D Identite(int p_dimension)
        {
            if (p_dimension < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(p_dimension));
            }

            Matrice2D matrice2D = new Matrice2D(p_dimension, p_dimension);

            for (int indiceLigneColonne = 0; indiceLigneColonne < p_dimension; indiceLigneColonne++)
            {
                matrice2D[indiceLigneColonne, indiceLigneColonne] = 1.0f;
            }

            return matrice2D;
        }

        public static Matrice2D operator +(Matrice2D p_matrice1, Matrice2D p_matrice2)
        {
            if (p_matrice1.NombreDeColonnes != p_matrice2.NombreDeColonnes
                || p_matrice1.NombreDeLignes != p_matrice2.NombreDeLignes)
            {
                throw new DimensionsNonConcordantesException();
            }

            Matrice2D resultat = new Matrice2D(p_matrice1.NombreDeLignes, p_matrice1.NombreDeColonnes);

            for (int indiceLigneResultat = 0; indiceLigneResultat < resultat.NombreDeLignes; indiceLigneResultat++)
            {
                for (int indiceColonneResultat = 0; indiceColonneResultat < resultat.NombreDeColonnes; indiceColonneResultat++)
                {
                    resultat[indiceLigneResultat, indiceColonneResultat] = p_matrice1[indiceLigneResultat, indiceColonneResultat] + p_matrice2[indiceLigneResultat, indiceColonneResultat];
                }
            }

            return resultat;
        }

        public static Matrice2D operator -(Matrice2D p_matrice1, Matrice2D p_matrice2)
        {
            if (p_matrice1.NombreDeColonnes != p_matrice2.NombreDeColonnes
                || p_matrice1.NombreDeLignes != p_matrice2.NombreDeLignes)
            {
                throw new DimensionsNonConcordantesException();
            }

            Matrice2D resultat = new Matrice2D(p_matrice1.NombreDeLignes, p_matrice1.NombreDeColonnes);

            for (int indiceLigneResultat = 0; indiceLigneResultat < resultat.NombreDeLignes; indiceLigneResultat++)
            {
                for (int indiceColonneResultat = 0; indiceColonneResultat < resultat.NombreDeColonnes; indiceColonneResultat++)
                {
                    resultat[indiceLigneResultat, indiceColonneResultat] = p_matrice1[indiceLigneResultat, indiceColonneResultat] - p_matrice2[indiceLigneResultat, indiceColonneResultat];
                }
            }

            return resultat;
        }

        public static Matrice2D operator *(Matrice2D p_matrice1, Matrice2D p_matrice2)
        {
            if (p_matrice1.NombreDeColonnes != p_matrice2.NombreDeLignes)
            {
                throw new DimensionsNonConcordantesException();
            }

            Matrice2D resultat = new Matrice2D(p_matrice1.NombreDeLignes, p_matrice2.NombreDeColonnes);

            for (int indiceLigneResultat = 0; indiceLigneResultat < resultat.NombreDeLignes; indiceLigneResultat++)
            {
                for (int indiceColonneResultat = 0; indiceColonneResultat < resultat.NombreDeColonnes; indiceColonneResultat++)
                {
                    float valeur = 0.0f;
                    for (int indiceColonneLigne = 0; indiceColonneLigne < p_matrice1.NombreDeColonnes; indiceColonneLigne++)
                    {
                        valeur += p_matrice1[indiceLigneResultat, indiceColonneLigne] * p_matrice2[indiceColonneLigne, indiceColonneResultat];
                    }

                    resultat[indiceLigneResultat, indiceColonneResultat] = valeur;
                }
            }

            return resultat;
        }

        public static Matrice2D operator *(Matrice2D p_matrice1, float p_valeur)
        {
            Matrice2D resultat = new Matrice2D(p_matrice1.NombreDeLignes, p_matrice1.NombreDeColonnes);

            for (int indiceLigneResultat = 0; indiceLigneResultat < resultat.NombreDeLignes; indiceLigneResultat++)
            {
                for (int indiceColonneResultat = 0; indiceColonneResultat < resultat.NombreDeColonnes; indiceColonneResultat++)
                {
                    resultat[indiceLigneResultat, indiceColonneResultat] = p_matrice1[indiceLigneResultat, indiceColonneResultat] * p_valeur;
                }
            }

            return resultat;
        }


        public override bool Equals(object p_obj)
        {
            Matrice2D convMat2d = p_obj as Matrice2D;
            bool egaux =
                   convMat2d != null
                && this.NombreDeLignes == convMat2d.NombreDeLignes
                && this.NombreDeColonnes == convMat2d.NombreDeColonnes
                ;

            for (int indiceLigne = 0; egaux && indiceLigne < this.NombreDeLignes; indiceLigne++)
            {
                for (int indiceColonne = 0; egaux && indiceColonne < this.NombreDeColonnes; indiceColonne++)
                {
                    // ici nous pouvons nous passer du si car les conditions des boucles inclus egaux
                    egaux = this[indiceLigne, indiceColonne] == convMat2d[indiceLigne, indiceColonne];
                }
            }

            return egaux;
        }

        public override int GetHashCode()
        {
            return this.m_donnees.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            float valeurMaximale = this.ValeurMaximale();

            int nombreCaracteresParColonne = (int)Math.Floor(Math.Log10(valeurMaximale)) + 1 // nombre de caractères de la valeur entière
                + NOMBRE_ESPACES_AVANT + NOMBRE_CHIFFRE_APRES_VIRGULE + 1; 

            for (int indiceLigne = 0; indiceLigne < this.NombreDeLignes; indiceLigne++)
            {
                sb.Append('|');
                for (int indiceColonne = 0; indiceColonne < this.NombreDeColonnes; indiceColonne++)
                {
                    sb.Append(this[indiceLigne, indiceColonne].ToString("n2").PadLeft(nombreCaracteresParColonne));
                }
                sb.AppendLine("|");
            }

            return sb.ToString();
        }

        private float ValeurMaximale()
        {
            float valeurCourante = default;
            float valeurMaximale = this[0, 0];
            for (int indiceLigne = 0; indiceLigne < this.NombreDeLignes; indiceLigne++)
            {
                for (int indiceColonne = 0; indiceColonne < this.NombreDeColonnes; indiceColonne++)
                {
                    valeurCourante = this[indiceLigne, indiceColonne];
                    if (valeurCourante > valeurMaximale)
                    {
                        valeurMaximale = valeurCourante;
                    }
                }
            }

            return valeurMaximale;
        }
    }
}
