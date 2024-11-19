namespace POOII_M01_E02_DI_Interfaces
{
    public interface IJournal
    {
        void Information(string message);
        void Avertissement(string message);
        void Erreur(string message);
    }
}
