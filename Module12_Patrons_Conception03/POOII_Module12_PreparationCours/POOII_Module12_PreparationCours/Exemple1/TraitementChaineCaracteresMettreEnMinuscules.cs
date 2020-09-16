using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module12_PreparationCours.Exemple1
{
    public class TraitementChaineCaracteresMettreEnMinuscules : ITraitementChaineCaracteres
    {
        public ITraitementChaineCaracteres Suivant { get; set; }

        public string TraiterChaineCaracteres(string p_chaine)
        {
            if (p_chaine is null)
            {
                throw new ArgumentNullException(nameof(p_chaine));
            }

            string res = p_chaine.ToLower();

            if (Suivant != null)
            {
                res = this.Suivant.TraiterChaineCaracteres(res);
            }

            return res;
        }
    }
}
