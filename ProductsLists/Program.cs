using System.Dynamic;
using static ProductsLists.AssignList;

namespace ProductsLists;
class Program 

{
    static void Main(string[] args)
    {
      Start: AddList();
        Console.WriteLine("What do you want to display =>  Name, Quantity, Price, Category , OrderCount OR ALL? \n 0 to Exit");
        string input = Console.ReadLine();

        switch (input.ToUpper())
        {
            case "NAME":
                ProductName();
                goto Start;

            case "QUANTITY":
                ProductQuantity();
                goto Start;

            case "PRICE":
                ProductPrice();
                goto Start;
            case "0":
                Environment.Exit(0);
                break;
            default:
                ProductList();
                break;
        }
    }
}
