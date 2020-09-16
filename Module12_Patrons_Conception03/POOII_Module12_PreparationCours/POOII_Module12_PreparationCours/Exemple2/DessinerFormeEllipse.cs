using POOII_Module12_PreparationCours.Exemple1;
using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module12_PreparationCours.Exemple2
{
    public class DessinerFormeEllipse : IDessinForme
    {
        public IDessinForme Suivant { get; set; }

        public void Dessiner(IFormeGeometrique p_forme)
        {
            if (p_forme is Ellipse)
            {
                Console.Out.WriteLine($"Je dessine une ellipse...");
            }
            else
            {
                this.Suivant?.Dessiner(p_forme);
            }
        }
    }
}
