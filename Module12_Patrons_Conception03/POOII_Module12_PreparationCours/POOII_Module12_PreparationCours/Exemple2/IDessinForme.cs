using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace POOII_Module12_PreparationCours.Exemple2
{
    public interface IDessinForme
    {
        public IDessinForme Suivant { get; set; }
        public void Dessiner(IFormeGeometrique p_forme);
    }
}
