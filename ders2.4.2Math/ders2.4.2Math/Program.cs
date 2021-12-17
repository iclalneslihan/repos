using System;

namespace ders2._4._2Math
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int mutlak7 = Math.Abs(-7);
            //    double cos45 = Math.Cos(45);
            //    Console.WriteLine(mutlak7);
            //    Console.WriteLine(cos45);
            //    Console.WriteLine(Math.Sin(45));
            //    Console.WriteLine(Math.Tan(45));


            //    string birlesim = String.Concat("Network", "Akademi", "203Sabah", 2021);
            //    Console.WriteLine(birlesim);
            //    int[] dizi = { 3, 4, 5, 6 };
            //    Console.WriteLine(String.Concat(dizi));



            //string str1 = "KADOKÖY";
            //string str2 = "kadıköy";

            //Console.WriteLine(String.Compare(str1, str2));
            //Console.WriteLine(String.Compare(str1,1, str2,1,3));
            //Console.WriteLine(String.Compare(str1,1, str2,1,3,false));



            //string mtn = "BEŞİKTAŞ";
            //Console.WriteLine(mtn.IndexOf("$"));
            //Console.WriteLine(mtn.LastIndexOf("$"));
            //Console.WriteLine(mtn.StartsWith("BEŞ"));
            //Console.WriteLine(mtn.EndsWith("TAŞ"));

            //string yazi = "FENERBAHÇE";
            //yazi = yazi.Trim();
            //yazi = yazi.Trim('B');
            //char[] dizi = { 'A', 'H', 'Ç', 'E' };
            //yazi = yazi.Trim(dizi);
            //Console.WriteLine(yazi);




            //string str3 = "MERHABA DÜNYA";

            //Console.WriteLine(str3.PadRight(15, 'E'));
            //Console.WriteLine(str3.PadLeft(15, 'E'));



            //string cumle = "Merhaba arkadaşlar. Bugün sınav var.";
            //string[] kelimeler = cumle.Split(' ');
            //foreach(var kelime in kelimeler)
            //{
            //    Console.WriteLine(kelime);
            //}

            //string yeniCumle = String.Join(' ', kelimeler);
            //Console.WriteLine(yeniCumle);



            //ÖR1: Girilen metindeki kelime sayısını bulan metodu yazınız.(boşluk)
        }


        //Console.WriteLine("Metin giriniz: ");
        //string metin ;
        //bosluk = " ";
        //string[] kelimeler = metin.Split(' ');
        //foreach (var bosluk in kelimeler)
        //{
        //    Console.WriteLine(kelime);
        //}

        //string kelimesayısı = String.Join(' ', kelimeler);
        //Console.WriteLine(kelimesayısı);


        static int kelimesay(string yazi);
        { 
           int toplamKelime = 0;
        string[] dizi = yazi.Split(' ');
        return dizi.Length -1;

         }

          

         //Ör2: Girilen metni tersten yazan programı metot kullanarak yazıız.


          static void TersYaz(string yazi)
    {
        for (int i = yazi.Length - 1; i >= 0; i--)
        {
            Console.Write(yazi[i]);
        }
    }

















        
    }
}
