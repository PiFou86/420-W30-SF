using POOII_Module04_SOLID_PreparationCours.ATM.Comptes;
using POOII_Module04_SOLID_PreparationCours.ATM.Tiroir;
using POOII_Module04_SOLID_PreparationCours.ATM.Transactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module04_SOLID_PreparationCours.ATM
{

    public class ATM
    {
        private CreateurTransaction m_createurTransaction;
        private TiroirArgent m_tiroirArgent;

        public ATM(TiroirArgent p_tiroirArgent, CreateurTransaction p_createurTransaction)
        {
            m_createurTransaction = p_createurTransaction;
            m_tiroirArgent = p_tiroirArgent;
        }

        public void Retirer(Compte p_compte, decimal p_montant)
        {
            Transaction transaction = m_createurTransaction.CreerTransactionRetirer(p_compte, p_montant);
            if (transaction.EstValide())
            {
                try
                {
                    transaction.ExecuterTransaction();
                    m_tiroirArgent.DistribuerArgent(p_montant);
                }
                catch (Exception ex)
                {
                    transaction.Annuler();
                }

            }
        }
    }
}
