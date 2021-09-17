using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module10_Observeur_Demo
{
    public class ChaineObservateurGenerique : IObserver<string>
    {
        private IDisposable _seDesabonner;
        private Action<string> _action;

        public ChaineObservateurGenerique(IObservable<string> p_sujet, Action<string> p_action)
        {
            if (p_sujet is null)
            {
                throw new ArgumentNullException(nameof(p_sujet));
            }

            if (p_action is null)
            {
                throw new ArgumentNullException(nameof(p_action));
            }

            this._action = p_action;
            this._seDesabonner = p_sujet.Subscribe(this);
        }

        public void SeDesabonner()
        {
            this._seDesabonner?.Dispose();
            this._seDesabonner = null;
        }

        public void OnCompleted()
        {
            this.SeDesabonner();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        // PFL : update
        public void OnNext(string p_valeur)
        {
            this._action(p_valeur);
        }
    }
}
