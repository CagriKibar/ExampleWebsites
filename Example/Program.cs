using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.City = "Çankırı";
            customer.FirstName = "Çağrı";
            customer.LastName = "Kibar";
            customer.Id = 1;

            Customer customer1 = new Customer {

                Id = 2, City = "İstanbul", FirstName = "Umutcan", LastName = "Kibar"
                

            };
            Console.WriteLine(customer1.LastName);
        }
    }
}
