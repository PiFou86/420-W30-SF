using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module12_PreparationCours.Exemple1
{
    public class TraitementChaineCaracteresAjouterPrefixeSuffixe : ITraitementChaineCaracteres
    {
        public ITraitementChaineCaracteres Suivant { get; set; }
        public string Prefixe { get; }
        public string Suffixe { get; }

        public TraitementChaineCaracteresAjouterPrefixeSuffixe(string p_prefixe, string p_suffixe)
        {
            this.Prefixe = p_prefixe ?? string.Empty;
            this.Suffixe = p_suffixe ?? string.Empty;
        }

        public string TraiterChaineCaracteres(string p_chaine)
        {
            if (p_chaine is null)
            {
                throw new ArgumentNullException(nameof(p_chaine));
            }

            string res = this.Prefixe + p_chaine + this.Suffixe;

            if (Suivant != null)
            {
                res = this.Suivant.TraiterChaineCaracteres(res);
            }

            return res;
        }
    }
}
