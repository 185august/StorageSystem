using StorageSystem;

var storage1 = new Storage();
storage1.AddProduct(new Electronic("electric car", 2000, 5));
storage1.AddProduct(new Electronic("Washing Machine", 6000, 5));
storage1.AddProduct(new Cloths("pants", 200, "Large"));
storage1.AddProduct(new Cloths("t-shirt", 100, "Medium"));
storage1.AddProduct(new Groceries("banana", 15, new DateOnly(2025, 5, 20)));
storage1.AddProduct(new Groceries("cookie", 5, new DateOnly(2025, 5, 14)));
storage1.RemoveProduct("pants");
storage1.PrintProducts();

