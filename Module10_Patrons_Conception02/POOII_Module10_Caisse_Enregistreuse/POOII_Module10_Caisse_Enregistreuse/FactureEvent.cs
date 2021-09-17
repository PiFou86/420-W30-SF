using System.Collections.Generic;

namespace POOII_Module10_Caisse_Enregistreuse
{
    public class FactureEvent
    {
        public FactureEventType Type { get; set; }
        public LigneFacture LigneFacture { get; set; }
        public Facture Facture { get; set; }
    }
}