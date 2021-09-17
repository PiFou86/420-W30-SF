using System;
using System.ComponentModel;
using System.Linq;

namespace POOII_Module11_Paint
{
    [Description("Flou")]
    public class TraitementImageFlou : TraitementImageMasque
    {
        public TraitementImageFlou() : base(TraiterDonnees)
        {
            ;
        }

        private static byte TraiterDonnees(byte[] p_donnees)
        {
            int somme = 0;
            for (int i = 0; i < p_donnees.Length; i++)
            {
                somme += p_donnees[i];
            }

            return (byte)(somme / p_donnees.Length);
        }
    }
}
