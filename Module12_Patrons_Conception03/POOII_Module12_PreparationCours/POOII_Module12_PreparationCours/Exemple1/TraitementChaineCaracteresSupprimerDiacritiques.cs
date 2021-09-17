using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace POOII_Module12_PreparationCours.Exemple1
{
    public class TraitementChaineCaracteresSupprimerDiacritiques : ITraitementChaineCaracteres
    {
        public ITraitementChaineCaracteres Suivant { get; set; }

        // Code : https://stackoverflow.com/questions/249087/how-do-i-remove-diacritics-accents-from-a-string-in-net
        public string TraiterChaineCaracteres(string p_chaine)
        {
            if (p_chaine is null)
            {
                throw new ArgumentNullException(nameof(p_chaine));
            }

            var normalizedString = p_chaine.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            string res = stringBuilder.ToString().Normalize(NormalizationForm.FormC);

            if (Suivant != null)
            {
                res = this.Suivant.TraiterChaineCaracteres(res);
            }

            return res;
        }
    }
}
