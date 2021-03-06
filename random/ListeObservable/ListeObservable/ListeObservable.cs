using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class ListeObservable<TypeElement> : IObservable<ListeObservableEvent<TypeElement>>, IList<TypeElement>
    {
        private List<IObserver<ListeObservableEvent<TypeElement>>> m_observateurs;
        private List<TypeElement> m_elements;


        public ListeObservable()
        {
            this.m_observateurs = new List<IObserver<ListeObservableEvent<TypeElement>>>();
            this.m_elements = new List<TypeElement>();
        }

        public TypeElement this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(TypeElement p_element)
        {
            this.m_elements.Add(p_element);
            this.m_observateurs.ForEach(o => o.OnNext(new ListeObservableEvent<TypeElement>()
            {
                Donnees = new List<TypeElement>(this.m_elements),
                Type = TypeListeObservableEvent.AJOUTER
            }));
        }

        public void Clear()
        {
            this.m_elements.Clear();
            this.m_observateurs.ForEach(o => o.OnNext(new ListeObservableEvent<TypeElement>()
            {
                Type = TypeListeObservableEvent.VIDER
            }));
        }

        public bool Contains(TypeElement item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(TypeElement[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<TypeElement> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(TypeElement item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, TypeElement item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(TypeElement item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public IDisposable Subscribe(IObserver<ListeObservableEvent<TypeElement>> observer)
        {
            this.m_observateurs.Add(observer);
            return new UnsubsribeListeObservable(() => this.m_observateurs.Remove(observer));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
