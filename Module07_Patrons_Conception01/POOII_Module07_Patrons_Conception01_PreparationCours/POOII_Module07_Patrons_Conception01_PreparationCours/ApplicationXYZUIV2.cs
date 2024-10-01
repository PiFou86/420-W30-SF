using System;

namespace POOII_Module07_Patrons_Conception01_PreparationCours;

public class ApplicationXYZUIV2
{
    public Action Saluer { get; set; }

    public ApplicationXYZUIV2(Action p_saluer)
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

        this.Saluer();
    }
}
