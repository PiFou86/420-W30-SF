using M01_DI_Interfaces;

namespace M01_DI_Implantation;

public class SalutationAnglais : ISalutation
{
    public void Saluer(string? nom = null)
    {
        string saluation = "Hello";
        if (nom != null)
        {
            saluation += $" {nom} !";
        }
        Console.Out.WriteLine(saluation);
    }
}
