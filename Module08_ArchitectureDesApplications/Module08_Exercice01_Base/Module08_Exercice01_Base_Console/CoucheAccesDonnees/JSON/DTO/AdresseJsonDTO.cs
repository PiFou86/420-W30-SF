using System;
using System.Collections.Generic;
using Module08_Exercice01_Base_Console.Entites;

namespace Module08_Exercice01_Base_Console.CoucheAccesDonnees.JSON.DTO
{
    public class AdresseJsonDTO
    {
        public Guid AdresseId { get; set; } = Guid.Empty;
        public int NumeroCivique { get; set; } = 0;
        public string InformationComplementaire { get; set; } = string.Empty;
        public string Odonyme { get; set; } = string.Empty;
        public string TypeVoie { get; set; } = string.Empty;
        public string CodePostal { get; set; } = string.Empty;
        public string NomMunicipalite { get; set; } = string.Empty;
        public string Etat { get; set; } = string.Empty;
        public string Pays { get; set; } = string.Empty;

        public AdresseJsonDTO() { }

        public AdresseJsonDTO(Adresse? p_adresse)
        {
            if (p_adresse is null)
            {
                throw new ArgumentNullException(nameof(p_adresse), "L'adresse ne peut pas être null.");
            }

            this.AdresseId = p_adresse.AdresseId;
            this.NumeroCivique = p_adresse.NumeroCivique;
            this.InformationComplementaire = p_adresse.InformationSupplementaire;
            this.Odonyme = p_adresse.Odonyme;
            this.TypeVoie = p_adresse.TypeVoie;
            this.CodePostal = p_adresse.CodePostal;
            this.NomMunicipalite = p_adresse.NomMunicipalite;
            this.Etat = p_adresse.Etat;
            this.Pays = p_adresse.Pays;
        }

        

        public Adresse VersEntite()
        {
            return new Adresse(this.AdresseId, this.NumeroCivique, this.InformationComplementaire, this.Odonyme, this.TypeVoie, this.CodePostal, this.NomMunicipalite, this.Etat, this.Pays);
        }
    }
}
