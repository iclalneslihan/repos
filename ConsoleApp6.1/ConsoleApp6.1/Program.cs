using System;

namespace ConsoleApp6._1
{
    class Program
    {
        static void Main(string[] args)
        {

            double fiyat = 100.0;
            
            
            Console.WriteLine(KDVhesapla(fiyat));
            Console.WriteLine(KDVhesapla(fiyat, "gıda"));
            Console.WriteLine(KDVhesapla(fiyat, "spor"));


            //int k = kare(7);
            //Console.WriteLine($"7 sayısının karesi = {k}");




            //int toplam = Topla(10,20);
            //Console.WriteLine($"toplam değişkenin değeri: {toplam}");

            //void ondefayaz();

        }
        //static void MerhabaDunya()
        //{
        //    Console.WriteLine("Merhaba Dünya!");
        //}
        //static int Topla(int s1,int s2)
        //{
        //    Console.WriteLine($"s1 = {s1}");
        //    Console.WriteLine($"s2 = {s2}");
        //    int toplam = s1 + s2;
        //    return toplam;
        //}
        //static void ondefayaz(string yazi)
        //{
          
        //    for(int i=1;i<=10;i++)
        //    { 
        //    Console.WriteLine(yazi);
        //    }
        //}

        //Kendisine gönderilen int tipindeki sayının karesini geri döndüren metodu yazınız.

        //static int kare(int s)
        //{
        //    return s * s;
          
        //}

        //Kendisine gönderilen fiyata %18 Kdv ekleyip geri döndüren metodu yazınız.
        //return tip: double,parametre tipidouble
        //yukarıdaki metoda ek olarak
        //ürün tipine göre kdv eklenecek urunTipi string olacak.
        //gıda %8,eğitim %5,diğerleri %18

        static double KDVhesapla(double s)
        {
            return  s * 1.18;

        }
        static double KDVhesapla(double s, string kategori)
        {
            if (kategori.ToLower() == "gıda")
                return s * 1.08;
            else if (kategori.ToLower() == "eğitim")
                return s * 1.05;
            else 
                return s * 1.18;
        }





    }
}
