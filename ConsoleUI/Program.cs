using Business.Concrete;
using DateAccess.Concrete.EntityFramework;
using DateAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
            
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCatergoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProducDetails())
            {
                Console.WriteLine(product.ProductNane+" - "+product.CategoryName);
            }
            

        }
    }
}
