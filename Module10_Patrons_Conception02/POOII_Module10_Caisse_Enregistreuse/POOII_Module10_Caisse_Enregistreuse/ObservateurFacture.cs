using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module10_Caisse_Enregistreuse
{
    public class ObservateurFacture : IObserver<FactureEvent>
    {
        private IObservable<FactureEvent> m_sujet;
        private Action<FactureEvent> m_action;
        private IDisposable m_seDesabonner;
        public ObservateurFacture(IObservable<FactureEvent> p_sujet, Action<FactureEvent> p_action)
        {
            this.m_sujet = p_sujet;
            this.m_action = p_action;

            this.m_seDesabonner = p_sujet.Subscribe(this);
        }

        public void OnCompleted()
        {
            this.m_seDesabonner.Dispose();
        }

        public void OnError(Exception error)
        {
            ;
        }

        public void OnNext(FactureEvent p_factureEvenement)
        {
            this.m_action(p_factureEvenement);
        }
    }
}
