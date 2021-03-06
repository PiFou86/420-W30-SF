using System;

namespace WindowsFormsApp1
{
    internal class ObserseurListe<TypeElement> : IObserver<ListeObservableEvent<TypeElement>>
    {
        private Action<ListeObservableEvent<TypeElement>> m_action;

        public ObserseurListe(Action<ListeObservableEvent<TypeElement>> p_action)
        {
            this.m_action = p_action;
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(ListeObservableEvent<TypeElement> value)
        {
            this.m_action(value);
        }
    }
}