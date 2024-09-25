namespace POOII_Module12_PreparationCours.Exemple1;

public interface ITraitementChaineCaracteres
{
    public ITraitementChaineCaracteres Suivant { get; set; }
    public string TraiterChaineCaracteres(string p_chaine);
}
