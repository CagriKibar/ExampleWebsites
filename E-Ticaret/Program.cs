using System;

namespace E_Ticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pro1 = new Product();//new ederek classımızı çağırıp özelliklerine isimler vereceğiz.
            pro1.UrunKategori = "Teknoloji";//1. ürün kategorisi Teknoloji
            pro1.UrunAdi = "MacbookPro";//Ve ürün isimlendirildi

            Product pro2 = new Product();
            pro2.UrunKategori = "Çok Satanlar";
            pro2.UrunAdi = "Lego Oyuncak";

            Product pro3 = new Product();
            pro3.UrunKategori = "Prime";
            pro3.UrunAdi = "Samsung Galaxy S21";

            Product pro4 = new Product();
            pro4.UrunKategori = "Moda";
            pro4.UrunAdi = "Kazak";


            Product pro5 = new Product();
            pro5.UrunKategori = "Hediye Fikirleri";
            pro5.UrunAdi = "PlayStation 5";

            Product pro6 = new Product();
            pro6.UrunKategori = "Kitap";
            pro6.UrunAdi = "Bir Ömür Nasıl Yaşanır ?";

            Product[] products = new Product[] { pro1, pro2, pro3, pro4, pro5, pro6 };//Diziye ekleyerek listelemeyi sağlayacağiz.

            foreach (var urun in products)//foreach diyerek Hızlı ve basit bir şekilde ekrana bastıracağiz.
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.UrunKategori);//urunun adı ve kategorisini ekrana bastırıyoruz.
            }
            Console.WriteLine("**********************************");//diğer döngü ile karışmaması için 

            for (int i = 0; i < products.Length; i++)//for döngüsü kullanarak ürünleri ve isimlerini listeledik.
            {
                Console.WriteLine(products[i].UrunAdi + " " + products[i].UrunKategori);//i dizi içerisinde gezerek bize ürünleri getirecek.
            }
            Console.WriteLine("Ürünler Sıralanmıştır ");// döngü bittiğinde uyarı verdik.


            Console.WriteLine("------------------");//karışmaması için 
            int j = 0;//while döngüsü içerisine girmek için int değerinde j değeri belirledik.

            while (j < products.Length )// j küçüktür ürünlerin uzunlugundan.
            {
                Console.WriteLine(products[j].UrunAdi + " " + products[j].UrunKategori);//j gezerek ürünleri ekrana bastırdık.
                j++;
            }
            
        }
    }
}
