namespace Version1;

public static class Demo01
{
    public static void Executer()
    {
        Console.Out.WriteLine("Demo01 :");
        Console.Out.WriteLine("--------");
        IContenant bol1 = new Bol();

        bol1.AjouterLiquide(new Cafe(250m));
        bol1.AjouterLiquide(new Lait(82.5m));

        Console.Out.WriteLine(bol1);
        bol1.Verser(100);
        Console.Out.WriteLine(bol1);
        Console.Out.WriteLine();

        IContenant bol2 = new Bol();
        bol2.AjouterLiquide(new Chocolat(250m));
        bol2.AjouterLiquide(new Creme(80m));

        Console.Out.WriteLine(bol2);
        bol2.Verser(100);
        Console.Out.WriteLine(bol2);
        Console.Out.WriteLine();

        IContenant tasse1 = new Tasse();
        tasse1.AjouterLiquide(new Cafe(150m));
        Console.Out.WriteLine(tasse1);
        tasse1.Verser(100);
        Console.Out.WriteLine(tasse1);
        Console.Out.WriteLine();

    }
}