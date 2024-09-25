using POOII_Module04_SOLID_PreparationCours.ATM.Comptes;
using POOII_Module04_SOLID_PreparationCours.ATM.Tiroir;
using POOII_Module04_SOLID_PreparationCours.ATM.Transactions;
using System;

namespace POOII_Module04_SOLID_PreparationCours.ATM;


public class ATM
{
    private ICreateurTransaction m_createurTransaction;
    private ITiroirArgent m_tiroirArgent;

    public ATM(ITiroirArgent p_tiroirArgent, ICreateurTransaction p_createurTransaction)
    {
        if (p_tiroirArgent == null)
        {
            throw new ArgumentNullException(nameof(p_tiroirArgent));
        }
        if (p_createurTransaction == null)
        {
            throw new ArgumentNullException(nameof(p_createurTransaction));
        }
        m_createurTransaction = p_createurTransaction;
        m_tiroirArgent = p_tiroirArgent;
    }

    public void Retirer(ICompte p_compte, decimal p_montant)
    {
        if (p_compte is null) { throw new ArgumentNullException(nameof(p_compte)); }
        if (p_montant <= 0) { throw new ArgumentException("Le montant doit être supérieur à 0", nameof(p_montant)); }

        ITransaction transaction = m_createurTransaction.CreerTransactionRetirer(p_compte, p_montant);
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
