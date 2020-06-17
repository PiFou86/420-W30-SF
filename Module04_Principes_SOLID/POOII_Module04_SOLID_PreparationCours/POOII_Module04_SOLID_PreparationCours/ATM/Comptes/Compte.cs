using POOII_Module04_SOLID_PreparationCours.ATM.Transactions;

namespace POOII_Module04_SOLID_PreparationCours.ATM.Comptes
{
    public interface Compte
    {
        void ExecuterTransaction(Transaction p_transaction);
    }
}