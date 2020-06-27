using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module03_TraitementExceptions
{
    public class Voiture
    {
        public bool Demarree { get; private set; }

        public void Demarrer()
        {
            if (this.Demarree)
            {
                throw new VoitureDejaDemarreeException();
            }

            this.Demarree = true;
        }

        public void Arreter()
        {
            if (!this.Demarree)
            {
                throw new VoitureDejaArreteeException();
            }

            this.Demarree = false;
        }
    }
}
