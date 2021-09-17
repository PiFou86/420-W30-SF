using System;
using System.Collections.Generic;

namespace POOII_Module10_Caisse_Enregistreuse
{
    internal class UnsubscribeFacture : IDisposable
    {
        private List<IObserver<FactureEvent>> m_observateursFacture;
        private IObserver<FactureEvent> m_observateurFacture;

        public UnsubscribeFacture(List<IObserver<FactureEvent>> p_obeservateurs, IObserver<FactureEvent> p_observateurFacture)
        {
            this.m_observateursFacture = p_obeservateurs;
            this.m_observateurFacture = p_observateurFacture;
        }

        public void Dispose()
        {
            this.m_observateursFacture.Remove(m_observateurFacture);
        }
    }
}