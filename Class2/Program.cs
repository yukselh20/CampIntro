using System;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrunIsmi = "Oyuncu Laptop'u";
            product1.UrunFiyatı = 7500;
            product1.StokAdedi = 750;

            Product product2 = new Product();
            product2.UrunIsmi = "Iphone 12";
            product2.UrunFiyatı = 12000;
            product2.StokAdedi = 650;

            Product product3 = new Product();
            product3.UrunIsmi = "Bluetooth Kulaklık";
            product3.UrunFiyatı = 500;
            product3.StokAdedi = 750;


            Product[] products = new Product[] {
            
            product1, product2, product3
            };


            foreach (var product in products)
            {
                Console.WriteLine(product.UrunIsmi + ":" + product.UrunFiyatı);
                Console.WriteLine("*******************************");
                
            }

            Console.WriteLine("----Foreach dögüsü bitti.----\n");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].UrunIsmi + ":" + products[i].UrunFiyatı);
                Console.WriteLine("*******************************");

            }

            Console.WriteLine("----For döngüsü bitti.----\n");


            int sayac = 0;
            while (sayac < products.Length)
            {
                Console.WriteLine(products[sayac].UrunIsmi + ":" + products[sayac].UrunFiyatı);
                Console.WriteLine("*******************************");
                sayac = sayac + 1;
            }
        }
    }

    class Product
    {
        public string UrunIsmi { get; set; }
        public int UrunFiyatı { get; set; }
        public int StokAdedi { get; set; }
    }
}
