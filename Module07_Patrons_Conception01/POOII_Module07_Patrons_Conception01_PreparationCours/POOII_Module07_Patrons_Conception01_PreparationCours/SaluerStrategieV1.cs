using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module07_Patrons_Conception01_PreparationCours
{
    public interface SaluerStrategieV1
    {
        void Executer();
    }

    public class SaluerConsoleFrancaisStrategieV1 : SaluerStrategieV1
    {
        public void Executer()
        {
            Console.Out.WriteLine("Bonjour !");
        }
    }

    public class SaluerConsoleAnglaisStrategieV1 : SaluerStrategieV1
    {
        public void Executer()
        {
            Console.Out.WriteLine("Hello !");
        }
    }
}
