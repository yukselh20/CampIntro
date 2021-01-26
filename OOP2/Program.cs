using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hamza Yüksel
            
            //Tüzel müşteri -- Gerçek müşteri
            
            IndividualCustomer indCustomer = new IndividualCustomer();
            indCustomer.CustomerNo = 12;
            indCustomer.Name = "Hamza";
            indCustomer.LastName = "Yüksel";
            indCustomer.TcId = "12345678900";

            CorporateCustomer corpCustomer = new CorporateCustomer();
            corpCustomer.CustomerNo = 101;
            corpCustomer.CompanyName = "Yüksel Otomasyon Sistemleri";
            corpCustomer.Id = 221;
            corpCustomer.TaxNo = "154782687597";


            // Inheritance ın başka bir özelliği de ana classın miras verdiği classları da tutabilmesidir.
            // Manager classında Add metoduna her birini ekleyebiliriz
            Customer customer1 = new IndividualCustomer(); 
            Customer customer2 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(corpCustomer);
            customerManager.Add(indCustomer);
           
            


        }
    }
}
