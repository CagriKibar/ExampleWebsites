using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri = new Musteri();
            musteri.MusteriId = 15;
            musteri.MusteriAd = "Çağrı";
            musteri.MusteriSoyad = "Kibar";

            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 16;
            musteri1.MusteriAd = "Umutcan";
            musteri1.MusteriSoyad = "Kibar";

            Musteri[] musteris = new Musteri[] { musteri, musteri1 };
            foreach (var musteriler in musteris)
            {
                Console.WriteLine("Müşteri Id: "+musteri.MusteriId+":  Müşteri Adı:  "+musteri.MusteriAd+":  Müşteri Soyadı: "+musteri.MusteriSoyad);
            }

            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri);
            musteriManager.Update(musteri);
        }

        
    }
}
