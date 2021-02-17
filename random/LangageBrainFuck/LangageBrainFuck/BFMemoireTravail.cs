using System;

namespace LangageBrainFuck
{
    public class BFMemoireTravail : IMemoireTravail
    {
        private byte[] m_memoire;
        private int m_tailleMemoire;
        private int m_positionIndex { get; set; }

        public byte ValeurCourante { get => this.m_memoire[this.m_positionIndex]; set => this.m_memoire[this.m_positionIndex] = value; }

        public BFMemoireTravail(int p_taille = 512)
        {
            this.m_tailleMemoire = p_taille;
        }

        public byte[] Dump()
        {
            byte[] donnees = new byte[this.m_memoire.Length];
            this.m_memoire.CopyTo(donnees, 0);
            return donnees;
        }

        public void IncrementerPositionIndex()
        {
            if (this.m_positionIndex == m_tailleMemoire - 1)
            {
                throw new System.OutOfMemoryException();
            }

            ++this.m_positionIndex;
        }

        public void DecrementerPositionIndex()
        {
            if (this.m_positionIndex == 0)
            {
                throw new System.OutOfMemoryException();
            }

            --this.m_positionIndex;
        }

        public void IncrementerValeur()
        {
            ++this.m_memoire[this.m_positionIndex];
        }

        public void DecrementerValeur()
        {
            --this.m_memoire[this.m_positionIndex];
        }

        internal void Initialiser()
        {
            this.m_positionIndex = 0;
            this.m_memoire = new byte[this.m_tailleMemoire];
        }
    }
}