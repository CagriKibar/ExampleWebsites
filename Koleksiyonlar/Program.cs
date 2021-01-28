using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "selam","nasılsın","iyi misin ?"};
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "çağrı", "kibar" };

            Console.WriteLine(isimler2[0]);
            isimler2.Add("C#");
            Console.WriteLine(isimler2[1]);




        }
    }
}
