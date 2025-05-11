namespace StorageSystem;

public class Groceries : IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public DateOnly ExpirationDate { get; set; }

    public Groceries(string name, double price, DateOnly expirationDate)
    {
        Name = name;
        Price = price;
        ExpirationDate = expirationDate;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price} and Expiration Date: {ExpirationDate.ToString("dd/MM/yyyy")}.");
    }
}