using Module06_Formats_Echanges_PreparationCours.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module06_Formats_Echanges_PreparationCours.Depots
{
    interface DepotDessin
    {
        Dessin LireDepot();
        void EnregistrerDessin(Dessin p_dessin);
    }
}
