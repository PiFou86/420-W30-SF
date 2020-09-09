using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module10_Caisse_Enregistreuse
{
    public class LigneFacture
    {
        public string Description { get; set; }
        public int Quantite { get; set; }
        public decimal PrixUnitaire { get; set; }
        public decimal Total { get { return this.PrixUnitaire * this.Quantite; } }
    }
}
