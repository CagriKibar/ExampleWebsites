using System;

namespace InterFaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
               new SqlServerCustomerDal()
            };
        }
        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }


        class Student : IPerson
        {
            public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
        class Customer : IPerson
        {
            public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }

        class PersonManager
        {
            public void Add(Customer customer)
            {
                Console.WriteLine(customer.FirstName);
            }
        }
    }
}
