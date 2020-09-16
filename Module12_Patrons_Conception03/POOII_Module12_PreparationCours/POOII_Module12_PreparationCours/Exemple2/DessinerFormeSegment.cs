﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module12_PreparationCours.Exemple2
{
    public class DessinerFormeSegment : IDessinForme
    {
        public IDessinForme Suivant { get; set; }

        public void Dessiner(IFormeGeometrique p_forme)
        {
            if (p_forme is Segment)
            {
                Console.Out.WriteLine($"Je dessine un segment...");
            }
            else
            {
                this.Suivant?.Dessiner(p_forme);
            }
        }
    }
}