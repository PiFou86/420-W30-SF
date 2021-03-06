using System;

namespace WindowsFormsApp1
{
    internal class UnsubsribeListeObservable :IDisposable
    {
        private Func<bool> m_action;

        public UnsubsribeListeObservable(Func<bool> p_action)
        {
            this.m_action = p_action;
        }

        public void Dispose()
        {
            this.m_action();
        }
    }
}