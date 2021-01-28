using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi");
        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi");
        }
    }
}
