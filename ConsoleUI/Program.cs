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
           // ProductTest();

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);

            }



            Console.ReadLine();
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var Product in productManager.GetByUnitPrice(50, 100))
            {
                Console.WriteLine(Product.ProductName);

            }
        }
    }
}
