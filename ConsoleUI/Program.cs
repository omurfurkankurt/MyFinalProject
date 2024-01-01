using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System.Net.Http.Headers;

namespace ConsoleUI
{    
    // SOLID
    // Open Closed Principle 
    // Yazılıma Yeni bir özelik eklenirse mevcutaki hiçbir koda dokunulmaz
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var Product in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(Product.ProductName);

            }

            Console.ReadLine();
        }
    }
}
