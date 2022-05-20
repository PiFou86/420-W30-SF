namespace Version3;

public static class Demo03
{
    public static void Executer()
    {
        Console.Out.WriteLine("Demo03 :");
        Console.Out.WriteLine("--------");
        IContenant bol1 = new Contenant("Bol", 350);

        bol1.AjouterLiquide(new Liquide("Cafe", 250m));
        bol1.AjouterLiquide(new Liquide("Lait", 82.5m));

        Console.Out.WriteLine(bol1);
        bol1.Verser(100);
        Console.Out.WriteLine(bol1);
        Console.Out.WriteLine();

        IContenant bol2 = new Contenant("Bol", 350);
        bol2.AjouterLiquide(new Liquide("Chocolat", 250m));
        bol2.AjouterLiquide(new Liquide("Creme", 80m));

        Console.Out.WriteLine(bol2);
        bol2.Verser(100);
        Console.Out.WriteLine(bol2);
        Console.Out.WriteLine();

        IContenant tasse1 = new Contenant("Tasse", 250m);
        tasse1.AjouterLiquide(new Liquide("Cafe", 150m));
        Console.Out.WriteLine(tasse1);
        tasse1.Verser(100);
        Console.Out.WriteLine(tasse1);
        Console.Out.WriteLine();

    }
}