namespace POOII_Module04_SOLID_PreparationCours.ATM.Transactions;

public interface ITransaction
{
    bool EstValide();
    void ExecuterTransaction();
    void Annuler();
}
