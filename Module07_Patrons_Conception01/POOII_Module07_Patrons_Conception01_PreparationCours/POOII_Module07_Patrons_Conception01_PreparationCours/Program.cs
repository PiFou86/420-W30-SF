using System;

namespace POOII_Module07_Patrons_Conception01_PreparationCours;

class Program
{
    static void Main(string[] args)
    {
        SingletonV3_ThreadSafe s = SingletonV3_ThreadSafe.Instance;
        s.ExempleMehodeDeVotreInstanceUnique();

        // Ou

        SingletonV3_ThreadSafe.Instance.ExempleMehodeDeVotreInstanceUnique();


        /////////////////////////////


        ApplicationXYZUIV1 app = new ApplicationXYZUIV1(new SaluerConsoleFrancaisStrategieV1());
        app.AccueillirUtilisateur();

        // Ou

        app.Saluer = new SaluerConsoleAnglaisStrategieV1();
        app.AccueillirUtilisateur();


        //////////////////////////////
        ///

        ApplicationXYZUIV2 app2 = new ApplicationXYZUIV2(SaluerStrategieV2.SaluerConsoleFrancaisStrategieV2);
        app2.AccueillirUtilisateur();

        // Ou

        app2.Saluer = SaluerStrategieV2.SaluerConsoleAnglaisStrategieV2;
        app2.AccueillirUtilisateur();

        // Ou

        app2.Saluer = () => Console.Out.WriteLine("Kaixo !");
        app2.AccueillirUtilisateur();

    }
}
