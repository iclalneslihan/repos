using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5._2
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Dizilerden farklı olarak.Kapasitesi sınırlı değildir.Otomatik genişler.

            //List<int> ilklistem = new List<int>();
            //List<string> sehirler = new List<string>() { "istanbul", "ixmir", "manisa", "van" };
            //List<int> araListe = new List<int>() { 1000, 2000, 3000 };

            //ilklistem.Add(1990);
            //ilklistem.Add(1231);
            //ilklistem.Add(1921);
            //ilklistem.Insert(0, 1988);
            //ilklistem.InsertRange(2, araListe);

            //Console.WriteLine(ilklistem[0]);
            //Console.WriteLine(ilklistem[1]);
            //Console.WriteLine(sehirler[3]);

            //foreach (var item in ilklistem)
            //{
            //    Console.WriteLine(item);

            //}


            ////Listenin toplam eleman sayısını bulma
            //ilklistem.WriteLine(sehirler.Count);


            //// CLEAR
            //ilklistem.Clear();

            //foreach (var item in ilklistem)
            //{
            //    Console.WriteLine(item);

            //}

            ////ÖR: 1-10 arasında rastgele 5'er sayı üretip iki listeye atan ve daha sonra
            ////listenin elemanlarından iki listede ortak olmayanları başka bir listeye atarak ekrana yazdıran prog.


            //List<int> l1 = new List<int>();
            //List<int> l2 = new List<int>();
            //List<int> l3 = new List<int>();

            //for (int i = 0; i < 5; i++)
            //{
            //    int sayi = rnd.Next(1, 10);
            //    l1.Add(sayi);
            //    Console.Write(sayi + " ");
            //}
            //Console.Write();
            //Console.WriteLine


            //for (int i = 0; i < 5; i++)
            //{
            //    int sayi = rnd.Next(1, 10);
            //    l2.Add(sayi);
            //    Console.Write(sayi + " ");
            //}

            //    foreach (var eleman in l1)
            //{
            //    if(l2.Contains(eleman)== false)
            

            //}
            //foreach (var item in l2)
            //{
            //    Console.WriteLine(item);
                

            //}
            //foreach (var item in l3)
            //{
            //    Console.WriteLine(item);
                

            //}


            //Random rnd = new Random();
            //int sayi = rnd.Next(1,10);!!!!!!!!!!!!!!!!!!!!!!!!!!!!!



                //1-20 arasında 15 sayı üretip bir listeye atın.
                //Kullanıcıdan bir tahmin alıp.Listede olup olmadığına bakın.
                //Listede var ise index numarasını ekrana yazdırın.


        //    List<int> l15 = new List<int>();
        //    Random rnd = new Random();

        //    for (int i = 0; i < 20; i++)
        //    {
        //        l15.Add(rnd.Next(1, 20));
        //    }
        //    Console.Write("tahmininiz : ");
        //    int tahmin = Convert.ToInt32(Console.ReadLine());

        //    if(l15.Contains(tahmin))
        //    {
        //        Console.WriteLine($"{tahmin} sayısının listedeki indeksi;{l15.IndexOf(tahmin)}");
        //    }

           

        //}



        //0-127 arasında 1 sayı üretin
        //Kullanıcıdan 15 karakter alıp bir listeye atın.
        //Programın sonunda kullanıcı karakteri bulursa.Tebrik etsin ve karakteri ekranda göstersin.
        //Bulamazsa girdiği karakterler arasından üretilen karaktere en yakın olanı ve farkını yazsın.


        Random rnd = new Random();
        byte rastGele = Convert.ToByte(rnd.Next(0,255));
            Console.WriteLine($"Üretilen : {rastGele}");
            byte mesafe = 255;

            List<int> tahminler = new List<int>();
            for(int i=0; i<5;i++)
            {
                Console.
                int k = Console.Read();
                tahminler.Add(k);


            }
            foreach (var item in tahminler)!!!!!!!!!


















        }
    }


