using System;

namespace POOII_Module04_SOLID_PreparationCours.ATM.Transactions
{
    public interface Transaction
    {
        bool EstValide();
        void ExecuterTransaction();
        void Annuler();
    }
}