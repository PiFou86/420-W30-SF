using LangageBrainFuck;
using System;

namespace LangageBrainFuckUI_Winforms
{
    public class ObservateurInterpreteur : IObserver<InterpreteurEvent>
    {
        private IObservable<InterpreteurEvent> m_sujet;
        private Action<InterpreteurEvent> m_action;
        private IDisposable m_seDesabonner;
        public ObservateurInterpreteur(IObservable<InterpreteurEvent> p_sujet, Action<InterpreteurEvent> p_action)
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

        public void OnNext(InterpreteurEvent p_interpreteurEvenement)
        {
            this.m_action(p_interpreteurEvenement);
        }
    }
}