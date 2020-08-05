using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module07_Patrons_Conception01_PreparationCours
{
    public class ApplicationXYZUIV1
    {
        public SaluerStrategieV1 Saluer { get; set; }

        public ApplicationXYZUIV1(SaluerStrategieV1 p_saluer)
        {
            if (p_saluer is null)
            {
                throw new ArgumentNullException();
            }

            this.Saluer = p_saluer;
        }

        public void AccueillirUtilisateur()
        {
            if (this.Saluer is null)
            {
                throw new InvalidOperationException("La stratégie de salutation n'est pas définie");
            }

            this.Saluer.Executer();
        }
    }
}
