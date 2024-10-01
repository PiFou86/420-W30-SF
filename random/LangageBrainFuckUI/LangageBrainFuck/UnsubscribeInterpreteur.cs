using System;
using System.Collections.Generic;

namespace LangageBrainFuck;

internal class UnsubscribeInterpreteur : IDisposable
{
    private List<IObserver<InterpreteurEvent>> m_obeservateurs;
    private IObserver<InterpreteurEvent> m_observateurInterpreteur;

    public UnsubscribeInterpreteur(List<IObserver<InterpreteurEvent>> p_obeservateurs, IObserver<InterpreteurEvent> p_observateurInterpreteur)
    {
        this.m_obeservateurs = p_obeservateurs;
        this.m_observateurInterpreteur = p_observateurInterpreteur;
    }

    public void Dispose()
    {
        this.m_obeservateurs.Remove(m_observateurInterpreteur);
    }
}
