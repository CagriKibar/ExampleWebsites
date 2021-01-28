using System;

namespace Odev
{
    class Program
    {
        //interface newlenemez.
        static void Main(string[] args)
        {
            IPersonManager personManager = new Customer();
            personManager.Add();

        }
    }
     interface IPersonManager
    {
         void Add();
        void update();
        
    }
    class Customer : IPersonManager
    {
        public void Add()
        {
            //müsteri ekleme kodları
            Console.WriteLine("Müşteri Eklendi");
        }

        public void update()
        {
            Console.WriteLine("Güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void update()
        {
            Console.WriteLine("Güncellendi");
        }

        class ProjectManager
        {
            public void Add()
            {
                Customer customer = new Customer();
                customer.Add();
            }
        }
    }
}
