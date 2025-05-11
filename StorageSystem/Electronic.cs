namespace StorageSystem;

public class Electronic : IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Warranty { get; set; }

    public Electronic(string name, double price, int warranty)
    {
        Name = name;
        Price = price;
        Warranty = warranty;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price}, And has a warranty of {Warranty} months");
    }
}