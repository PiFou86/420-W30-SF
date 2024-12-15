﻿using Module08_Exercice01_Base_Console.Entites;
using System;

namespace Module08_Exercice01_Base_Console.CoucheAccesDonnees.JSON.DTO;

public class AdresseJsonDTO
{
    public AdresseJsonDTO() { }

    public AdresseJsonDTO(Adresse p_adresse)
    {
        this.AdresseId = p_adresse.AdresseId;
        this.NumeroCivique = p_adresse.NumeroCivique;
        this.InformationComplementaire = p_adresse.InformationSupplementaire;
        this.Odonyme = p_adresse.Odonyme;
        this.TypeVoie = p_adresse.TypeVoie;
        this.CodePostal = p_adresse.CodePostal;
        this.NomMunicipalite = p_adresse.NomMunicipalite;
        this.Etat = p_adresse.Etat;
        this.Pays = p_adresse.Pays;
    }

    public Guid AdresseId { get; set; }
    public int NumeroCivique { get; set; }

    public Adresse VersEntite()
    {
        return new Adresse(this.AdresseId, this.NumeroCivique, this.InformationComplementaire, this.Odonyme, this.TypeVoie, this.CodePostal, this.NomMunicipalite, this.Etat, this.Pays);
    }

    public string InformationComplementaire { get; set; }
    public string Odonyme { get; set; }
    public string TypeVoie { get; set; }
    public string CodePostal { get; set; }
    public string NomMunicipalite { get; set; }
    public string Etat { get; set; }
    public string Pays { get; set; }
}
