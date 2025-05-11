namespace StorageSystem;

public interface IProduct
{
    string Name { get; set; }
    double Price { get; set; }
    void PrintInfo();
}