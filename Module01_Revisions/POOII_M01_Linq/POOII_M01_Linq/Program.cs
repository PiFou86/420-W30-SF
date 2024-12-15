
// Exercice 3.1
using ExperimentationsLINQ;

List<int> nombres = Enumerable.Range(1, 100).ToList();
Console.Out.WriteLine($"Nombres : {string.Join(" ", nombres)}");
Console.Out.WriteLine($"Nombres pairs : {string.Join(" ", nombres.Where(n => (n & 1) == 0))}");
Console.Out.WriteLine("Nombres impairs : ");
nombres.Where(n => (n & 1) == 1).ToList().ForEach(n => Console.Out.WriteLine(n));
Console.Out.WriteLine($"Nombres pairs : {string.Join(" ", nombres.Select(n => n * 3))}");

// Exercice 3.2
Console.Out.WriteLine("Affichez la liste des produits triés par prix");
ObjectDumper.Write(DonneesLINQ.CreateProductList().OrderBy(p => p.UnitPrice));

Console.Out.WriteLine("Affichez la liste des produits dont le nom contient `z`");
ObjectDumper.Write(DonneesLINQ.CreateProductList().Where(p => p.ProductName.Contains("z")));

Console.Out.WriteLine("Affichez la liste des noms de produits dont le prix est supérieur à 100 et dont le nom contient `z`");
ObjectDumper.Write(DonneesLINQ.CreateProductList().Where(p => p.ProductName.Contains("z") && p.UnitPrice > 100));

Console.Out.WriteLine("Affichez le produit le plus cher");
ObjectDumper.Write(DonneesLINQ.CreateProductList().OrderByDescending(p => p.UnitPrice).First());

Console.Out.WriteLine("Affichez le produit dont l'identifiant est `23`");
ObjectDumper.Write(DonneesLINQ.CreateProductList().Where(p => p.ProductID == 23).Single());

Console.Out.WriteLine("Affichez le produit dont l'identifiant est `123`");
ObjectDumper.Write(DonneesLINQ.CreateProductList().Where(p => p.ProductID == 123).SingleOrDefault());
