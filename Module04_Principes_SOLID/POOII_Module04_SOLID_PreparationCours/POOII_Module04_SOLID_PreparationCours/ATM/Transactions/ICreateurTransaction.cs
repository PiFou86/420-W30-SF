﻿using POOII_Module04_SOLID_PreparationCours.ATM.Comptes;
using System;

namespace POOII_Module04_SOLID_PreparationCours.ATM.Transactions
{
    public interface ICreateurTransaction
    {
        ITransaction CreerTransactionRetirer(ICompte p_compte, decimal p_montant);
    }
}