using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace POOII_Module11_Paint
{
    [Description("Diminuer bruit")]
    public class TraitementImageDiminuerBruit : TraitementImageMasque
    {
        public TraitementImageDiminuerBruit() : base(TraiterDonnees)
        {
            ;
        }

        private static byte TraiterDonnees(byte[] p_donnees)
        {
            Array.Sort(p_donnees);

            return p_donnees[p_donnees.Length / 2];
        }
    }
}
