using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class ObserseurListeListBox<TypeElement> : IObserver<ListeObservableEvent<TypeElement>> where TypeElement : class
    {
        private ListBox m_lb;

        public ObserseurListeListBox(ListBox p_lb)
        {
            this.m_lb = p_lb;
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(ListeObservableEvent<TypeElement> value)
        {
            switch (value.Type)
            {
                case TypeListeObservableEvent.AJOUTER:
                    this.m_lb.Items.Clear();
                    this.m_lb.Items.AddRange(value.Donnees.ToArray());

                    break;
                case TypeListeObservableEvent.VIDER:
                    break;
                default:
                    break;
            }

        }
    }
}