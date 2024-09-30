using M01_DI_Interfaces;

namespace M01_DI_Implantation
{
    public class SalutationBasque : ISalutation
    {
        public void Saluer(string? nom = null)
        {
            string saluation = "Kaixo";
            if (nom != null)
            {
                saluation += $" {nom} !";
            }
            Console.Out.WriteLine(saluation);
        }
    }
}
