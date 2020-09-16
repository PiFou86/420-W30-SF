using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module12_PreparationCours.Exemple2
{
    public class DessinerFormeSentinelle : IDessinForme
    {
        public IDessinForme Suivant
        {
            get
            {
                return null;
            }
            set
            {
                throw new InvalidOperationException();
            }
        }

        public void Dessiner(IFormeGeometrique p_forme)
        {
            throw new ArgumentOutOfRangeException(nameof(p_forme), $"Aucun traitement pour la forme {p_forme.GetType().Name}");
        }
    }
}
