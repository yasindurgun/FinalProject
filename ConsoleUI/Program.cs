using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByUnitPrice(10,75))
            {
                Console.Write(product.ProductId+"\t");
                Console.Write(product.ProductName+"\t");
                Console.WriteLine(product.UnitPrice);
            }

            Console.ReadKey();
        }
    }
}
