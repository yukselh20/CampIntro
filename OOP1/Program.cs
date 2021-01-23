using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 1500;


            Product product2 = new Product { Id = 2, CategoryId = 5, 
                ProductName= "kalem", UnitPrice=5, UnitsInStock=32 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);



        }
    }
}
