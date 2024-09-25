using System;
using System.Collections.Generic;

namespace POOII_Module10_Observeur_Demo;

public class UnsubscribeChaineObservable : IDisposable
{
    private IObserver<string> _observer;
    private List<IObserver<string>> _observers;

    public UnsubscribeChaineObservable(List<IObserver<string>> p_observateurs, IObserver<string> p_observateur)
    {
        this._observer = p_observateur;
        this._observers = p_observateurs;
    }

    // PFL : dettach
    public void Dispose()
    {
        this._observers.Remove(this._observer);
    }
}
