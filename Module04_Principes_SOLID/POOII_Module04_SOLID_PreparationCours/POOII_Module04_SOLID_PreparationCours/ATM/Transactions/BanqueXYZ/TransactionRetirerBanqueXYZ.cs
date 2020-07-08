using POOII_Module04_SOLID_PreparationCours.ATM.Comptes;
using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module04_SOLID_PreparationCours.ATM.Transactions.BanqueXYZ
{
    public class TransactionRetirerBanqueXYZ : ITransaction
    {
        private readonly ICompte m_compte;
        private decimal m_montant;

        public TransactionRetirerBanqueXYZ(ICompte p_compte, decimal p_montant)
        {
            this.m_compte = p_compte;
            this.m_montant = p_montant;
        }

        public void Annuler()
        {
            throw new NotImplementedException();
        }

        public bool EstValide()
        {
            return true;
        }

        public void ExecuterTransaction()
        {
            Console.Out.WriteLine($"{this.GetType().Name} - Executer transaction retirer {m_montant}");
        }
    }
}
