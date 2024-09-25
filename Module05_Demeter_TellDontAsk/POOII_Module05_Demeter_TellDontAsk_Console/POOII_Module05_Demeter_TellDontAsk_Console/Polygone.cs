using System;
using System.Collections.Generic;

namespace POOII_Module05_Demeter_TellDontAsk_Console;

public class Polygone
{
    public List<Point3d> Sommets { get; set; }
    public void AffConsole()
    {
        foreach (Point3d item in this.Sommets)
        {
            Console.Out.WriteLine($"X : {item.X}, Y : {item.Y}, Z : {item.Z}");
        }
    }
}
