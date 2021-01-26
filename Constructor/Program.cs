using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id=1,FirstName="Hamza",LastName="Yüksel",City="İstanbul" };
            Customer customer1 = new Customer(2,"Hamza","Yüksel","İstanbul");

            Console.WriteLine(customer1.FirstName);
        }
    }

    class Customer
    {
        // overloading. Bu da istediğimiz şekilde customer 2 çalişması için uygundur
        // FirstName gibi değerlere ulaşmak için girilen değeri constructor yapısında belirtmemeiz gerekli.
        public Customer(int id, string fname, string lastname, string city)
        {
            FirstName = fname;
            LastName = lastname;
            City = city;
        }

        // defoult constructor customer 1 kullanımı için uygundur. Ayrıca her class çağırıldığında çalışır.
        public Customer()
        {
           
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
