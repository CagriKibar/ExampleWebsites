using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Person[] people = new Person[3] { 
                new Customer { FirstName="Çağrı"},
                new Student { FirstName="Umut"},
                new Person { FirstName="Kumsal"} };

            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
            
        }
        

	}

    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer: Person
    {
        public string City { get; set; }
    }
    class Student :Person
    {

    }

