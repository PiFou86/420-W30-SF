using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace POOII_Module10_Caisse_Enregistreuse
{
    public class Facture : IObservable<FactureEvent>
    {
        private List<IObserver<FactureEvent>> m_obeservateurs;
        public List<LigneFacture> LignesFacture { get; private set; }
        public decimal Total { 
            get
            {
                return this.LignesFacture.Sum(lf => lf.Total);
            }
        }

        public Facture()
        {
            this.m_obeservateurs = new List<IObserver<FactureEvent>>();
            this.LignesFacture = new List<LigneFacture>();
        }

        public IDisposable Subscribe(IObserver<FactureEvent> p_observateurFacture)
        {
            if (p_observateurFacture is null)
            {
                throw new ArgumentNullException(nameof(p_observateurFacture));
            }

            this.m_obeservateurs.Add(p_observateurFacture);

            return new UnsubscribeFacture(this.m_obeservateurs, p_observateurFacture);
        }

        public void AjouterLigneFacture(LigneFacture p_ligneFacture)
        {
            if (p_ligneFacture is null)
            {
                throw new ArgumentNullException(nameof(p_ligneFacture));
            }

            this.LignesFacture.Add(p_ligneFacture);
            this.m_obeservateurs.ForEach(
                observateur => observateur.OnNext(new FactureEvent()
                {
                    Type = FactureEventType.AJOUT_LIGNE,
                    LigneFacture = p_ligneFacture,
                    Facture = this
                })
            );
        }

        public void Nouvelle()
        {
            this.LignesFacture = new List<LigneFacture>();
            this.m_obeservateurs.ForEach(
                observateur => observateur.OnNext(new FactureEvent()
                {
                    Type = FactureEventType.NOUVELLE,
                    LigneFacture = null,
                    Facture = this
                })
            );
        }
    }
}
