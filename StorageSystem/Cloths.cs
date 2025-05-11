namespace StorageSystem;

public class Cloths : IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Size { get; set; }

    public Cloths(string name, double price, string size)
    {
        Name = name;
        Price = price;
        Size = size;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price} and Size: {Size}");
    }
}