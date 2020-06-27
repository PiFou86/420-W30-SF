using FluentAssertions;
using POOII_Module03_TraitementExceptions.Matrices;
using System;
using Xunit;

namespace TestsPOOII_Module03_TraitementExceptions
{
    public class TestsMatrice2D
    {

        [Fact]
        public void Identity_Dimension0_Exception()
        {
            int dimension = 0;

            Action act = () => Matrice2D.Identite(dimension);
            
            act.Should().Throw<ArgumentOutOfRangeException>();
        }
        [Fact]
        public void Identity_Dimension1_MatriceIdentite1Ligne1Colonne()
        {
            Matrice2D attendue = new Matrice2D(new float[,]
            {
                {1},
            });
            int dimension = 1;

            Matrice2D identite = Matrice2D.Identite(dimension);

            identite.Should().Be(attendue);
        }
        [Fact]
        public void Identity_Dimension2_MatriceIdentite2Lignes2Colonnes()
        {
            Matrice2D attendue = new Matrice2D(new float[,]
            {
                {1, 0},
                {0, 1},
            });
            int dimension = 2;

            Matrice2D identite = Matrice2D.Identite(dimension);

            identite.Should().Be(attendue);
        }

        [Fact]
        public void Identity_Dimension3_MatriceIdentite3Lignes3Colonnes()
        {
            Matrice2D attendue = new Matrice2D(new float[,] 
            {
                {1, 0, 0},
                {0, 1, 0},
                {0, 0, 1},
            });
            int dimension = 3;

            Matrice2D identite = Matrice2D.Identite(dimension);

            identite.Should().Be(attendue);
        }

        [Fact]
        public void OperateurMultiplication_Cas23x32_Matrice22()
        {
            Matrice2D operande1 = new Matrice2D(new float[,]
            {
                {1, 2, 0},
                {4, 3, -1},
            });
            Matrice2D operande2 = new Matrice2D(new float[,]
            {
                {5, 1},
                {2, 3},
                {3, 4},
            });
            Matrice2D resultatAttendu = new Matrice2D(new float[,]
            {
                {9, 7},
                {23, 9},
            });

            Matrice2D resultatCalcule = operande1 * operande2;

            resultatCalcule.Should().Be(resultatAttendu);
        }

        [Fact]
        public void OperateurMultiplication_Cas32x23_Matrice33()
        {
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

            Matrice2D resultatCalcule = operande1 * operande2;

            resultatCalcule.Should().Be(resultatAttendu);
        }
        // Autres tests...
    }
}
