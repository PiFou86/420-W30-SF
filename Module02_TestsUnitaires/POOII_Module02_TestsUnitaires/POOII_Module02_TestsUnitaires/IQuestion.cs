namespace POOII_Module02_TestsUnitaires;

public interface IQuestion
{
    int NombrePointsTotal { get; }
    void PoserQuestion();
    int CorrigerReponse();
}
