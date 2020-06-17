using POOII_Module04_SOLID_PreparationCours.ATM.Comptes;
using System;

namespace POOII_Module04_SOLID_PreparationCours.ATM.Transactions
{
    public interface CreateurTransaction
    {
        Transaction CreerTransactionRetirer(Compte p_compte, decimal p_montant);
    }
}