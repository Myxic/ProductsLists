using System;
using System.Diagnostics;
using System.Dynamic;
using System.Xml.Linq;

namespace ProductsLists
{
    public class AssignList
    {
        public static List<Product> products = new List<Product>();
        public static dynamic productProperties = new ExpandoObject();

        public static void AddList()
        {
            Console.WriteLine("\n\t Product Description\n=======================================================================\t");

            products.Add(new Product() { Id = 1, Name = "Dell Xps", Quantity = 30, Price = 1500, Category = "PCs", OrderCount = 1000 });
            products.Add(new Product() { Id = 2, Name = "Ergonomic Chair", Quantity = 400, Price = 200, Category = "Chairs", OrderCount = 4000 });
            products.Add(new Product() { Id = 3, Name = "Table", Quantity = 500, Price = 250, Category = "Tables", OrderCount = 3000 });


            

        }
        public static void ProductList()
	    {
           
            foreach (Product p in products)
            { 

                productProperties.Name = p.Name;
                productProperties.Quantity = p.Quantity;
                productProperties.OrderCount = p.OrderCount;

                Console.WriteLine($"{productProperties.Name}, {productProperties.Quantity}, {productProperties.OrderCount}");
            }
        }
        public static void ProductName() 
	    {
           
            foreach (Product p in products)
            {

                productProperties.Id = p.Id;
                productProperties.Name = p.Name;
              

                Console.WriteLine($"{productProperties.Id}\t Name=>{productProperties.Name}");
            }
        }

        public static void ProductQuantity()
        {

            foreach (Product p in products)
            {

                productProperties.Id = p.Id;
                productProperties.Quantity = p.Quantity;


                Console.WriteLine($"{productProperties.Id}\t  Quanitity=>{productProperties.Quantity}");
            }
        }
        public static void ProductPrice()
        {

            foreach (Product p in products)
            {

                productProperties.Id = p.Id;
                productProperties.Price = p.Price;


                Console.WriteLine($"{productProperties.Id}\t Price=>{productProperties.Price}");
            }
        }

    }
}

