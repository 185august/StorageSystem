namespace StorageSystem;

public class Storage
{
    private readonly List<IProduct?> _products = new List<IProduct?>();
    
    public void AddProduct(IProduct? product) => 
        _products.Add(product);

    public void PrintProducts()
    {
        foreach (var product in _products)
        {
            product.PrintInfo();
        }
    }

    public void RemoveProduct(string name)
    {
        _products.Remove(_products.Find(x => x.Name == name));
    }
}