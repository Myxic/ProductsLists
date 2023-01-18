using System.Dynamic;

namespace ProductsLists;
class Program : Product
{
    static void Main(string[] args)
    {

        Console.WriteLine("\n\t Product Description\n=======================================================================\t");

        List<Product> products = new List<Product>();

        products.Add(new Product() { Id = 1, Name = "Dell Xps", Quantity = 30, Price = 1500, Category = "PCs", OrderCount = 1000 });
        products.Add(new Product() { Id = 2, Name = "Ergonomic Chair", Quantity = 400, Price = 200, Category = "Chairs", OrderCount = 4000 });
        products.Add(new Product() { Id = 3, Name = "Table", Quantity = 500, Price = 250, Category = "Tables", OrderCount = 3000 });


        foreach (Product p in products)
        {
            dynamic productProperties = new ExpandoObject();

            productProperties.Name = $"{p.Name}, {p.Quantity}";
            productProperties.Quantity = p.Quantity;
            productProperties.OrderCount = p.OrderCount;

            Console.WriteLine($"Name=>{productProperties.Name}, Quantity =>{productProperties.Quantity}, OrderCount =>{productProperties.OrderCount}");
        }
    }
}
