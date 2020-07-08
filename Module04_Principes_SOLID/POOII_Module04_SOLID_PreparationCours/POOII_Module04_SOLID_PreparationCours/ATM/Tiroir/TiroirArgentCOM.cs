using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module04_SOLID_PreparationCours.ATM.Tiroir
{
    class TiroirArgentCOM : ITiroirArgent
    {
        public void DistribuerArgent(decimal p_montant)
        {
            Console.Out.WriteLine($"{this.GetType().Name} - Distribution de {p_montant}");
        }
    }
}
