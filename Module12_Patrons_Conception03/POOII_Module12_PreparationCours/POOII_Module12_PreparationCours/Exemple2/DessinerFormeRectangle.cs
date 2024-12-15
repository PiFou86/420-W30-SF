using System;

namespace POOII_Module12_PreparationCours.Exemple2;

public class DessinerFormeRectangle : IDessinForme
{
    public IDessinForme Suivant { get; set; }

    public void Dessiner(IFormeGeometrique p_forme)
    {
        if (p_forme is Rectangle)
        {
            Console.Out.WriteLine($"Je dessine un rectangle...");
        }
        else
        {
            this.Suivant?.Dessiner(p_forme);
        }
    }
}
