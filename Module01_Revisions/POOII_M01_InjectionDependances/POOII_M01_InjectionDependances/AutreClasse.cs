using M01_DI_Interfaces;

namespace POOII_M01_InjectionDependances;

internal class AutreClasse
{
    private ISalutation m_salutation;
    public AutreClasse(ISalutation salutation)
    {
        this.m_salutation = salutation;
    }

    public void Saluer(string nom)
    {
        this.m_salutation.Saluer(nom);
    }
}
