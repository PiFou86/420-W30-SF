namespace LangageBrainFuck;

public class BFMemoireTravail : IMemoireTravail
{
    private byte[] m_memoire;
    private int m_tailleMemoire;
    public int PositionIndex { get; private set; }

    public byte ValeurCourante { get => this.m_memoire[this.PositionIndex]; set => this.m_memoire[this.PositionIndex] = value; }

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
        if (this.PositionIndex == m_tailleMemoire - 1)
        {
            throw new System.OutOfMemoryException();
        }

        ++this.PositionIndex;
    }

    public void DecrementerPositionIndex()
    {
        if (this.PositionIndex == 0)
        {
            throw new System.OutOfMemoryException();
        }

        --this.PositionIndex;
    }

    public void IncrementerValeur()
    {
        ++this.m_memoire[this.PositionIndex];
    }

    public void DecrementerValeur()
    {
        --this.m_memoire[this.PositionIndex];
    }

    internal void Initialiser()
    {
        this.PositionIndex = 0;
        this.m_memoire = new byte[this.m_tailleMemoire];
    }
}
