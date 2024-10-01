namespace ExperimentationsLINQ;

public class Product
{
    public int ProductID { get; set; }
    public required string ProductName { get; set; }
    public required string Category { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}
