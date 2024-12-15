using System;
using System.Collections.Generic;

namespace POOII_Module10_Observeur_Demo;

// Sujet
public class ChaineObservable : IObservable<string>
{
    private List<IObserver<string>> m_observeurs;
    private string m_valeur;
    public ChaineObservable()
    {
        this.m_observeurs = new List<IObserver<string>>();
    }

    public string Valeur
    {
        get
        {
            return this.m_valeur;
        }
        set
        {
            this.m_valeur = value;
            this.InformerObersateurValeurChangee();
        }
    }

    private void InformerObersateurValeurChangee()
    {
        this.m_observeurs.ForEach(observer =>
        observer.OnNext(this.Valeur)
        );
    }

    // PFL : attach
    public IDisposable Subscribe(IObserver<string> p_observateur)
    {
        if (p_observateur is null)
        {
            throw new ArgumentNullException(nameof(p_observateur));
        }

        this.m_observeurs.Add(p_observateur);

        return new UnsubscribeChaineObservable(this.m_observeurs, p_observateur);
    }
}
