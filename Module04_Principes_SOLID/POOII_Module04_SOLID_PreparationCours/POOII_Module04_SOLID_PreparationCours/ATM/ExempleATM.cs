using POOII_Module04_SOLID_PreparationCours.ATM.Comptes;
using POOII_Module04_SOLID_PreparationCours.ATM.Tiroir;
using POOII_Module04_SOLID_PreparationCours.ATM.Transactions.BanqueXYZ;
using System;

namespace POOII_Module04_SOLID_PreparationCours.ATM
{
    static class ExempleATM
    {
        public static void Demo()
        {
            ATM atm = new ATM(new TiroirArgentUSB(), new CreateurTransactionBanqueXYZ());

            /// ...
            ICompte compte = new CompteCourant(); // ...
            decimal montant = 123.00m; // ...
            /// ...

            atm.Retirer(compte, montant);
        }
    }
}



