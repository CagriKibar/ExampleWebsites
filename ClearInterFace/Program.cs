using System;

namespace ClearInterFace
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager();
                new Worker();
                new Robot();

            };
        }
        interface IWorker
        {
            void Work();
            

        }

        interface IEat
        {
            void Eat();
        }
        interface ISalary
        {
            void GetSalary();
        }
        class Manager : IWorker
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }

        class Worker : IWorker, ISalary, IEat
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void GetSalary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }
        class Robot : IWorker
        {
            public void Work()
            {
                throw new NotImplementedException();
            }
        }
    }
   
}
