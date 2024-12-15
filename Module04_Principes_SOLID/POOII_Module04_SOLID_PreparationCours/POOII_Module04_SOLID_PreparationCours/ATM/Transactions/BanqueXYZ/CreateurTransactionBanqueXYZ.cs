﻿using POOII_Module04_SOLID_PreparationCours.ATM.Comptes;

namespace POOII_Module04_SOLID_PreparationCours.ATM.Transactions.BanqueXYZ;

public class CreateurTransactionBanqueXYZ : ICreateurTransaction
{
    public ITransaction CreerTransactionRetirer(ICompte p_compte, decimal p_montant)
    {
        return new TransactionRetirerBanqueXYZ(p_compte, p_montant);
    }
}
