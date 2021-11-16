using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi = sayigir();
            // Console.WriteLine("Girilen sayı : " + sayi);




            //double besfaktoriyeli = fakt(5);
            //Console.WriteLine($"5 sayısının faktöriyeli {besfaktoriyeli}");


            //Console.WriteLine($"7 asal mı : {isPrime(7)}");
            //Console.WriteLine($"15 asal mı : {isPrime(15)}");


            //int[] rastgele10 = Random10();
            //forech ( item in rastgele10)
            //    {
            //    Console.WriteLine(item);
            //    }


            //int[] sayilar = { 10, 20, 30, 40, 50, 11, 22, 33, 44, 55 };
            //diziYaz(sayilar);
            //int[] tekSayilar = diziTekleri(sayilar);
            //diziYaz(tekSayilar);


            //Console.Write("Bir sayı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Bir sayı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write(buyuksayi(sayi1, sayi2));





            //Console.WriteLine(buyuk2li(99, 127));
            //Console.WriteLine(buyuk3lu(99, 127,256));


            ////liste sorusu
            //List<int> sayilarim = new List<int>() { 2, 3, 4, 5 };
            //List<int> karelerim = listeKare(sayilarim);

            //int boyut = sayilarim.Count();
            //for(int i=0; i<boyut;i++)
            //{
            //    Console.WriteLine($"{sayilarim[i]} sayısının karesi = {karelerim[i]}");
            //}



            //foreach (var item in sayiGetir10())
            //{
            //    Console.Write(item + " ");
            //}

            List<int> sayiListesi = sayiuret(5, 25, 7);
            foreach(var item in sayiListesi)
            {
                Console.Write($"{item}  ");
            }





        }

        //Sayı girişini otomatikleştiren metodu yazınız
        //Kullanıcıdan alınan int tipindeki sayıyı döndürecek.
        //int sayi = sayiGir();


        //static int sayigir()
        //{
        //    Console.Write("sayı = ");
        //    int sayi = Convert.ToInt32(Console.ReadLine());

        //    return sayi ;
        //}


        //Aldığı sayının faktöriyelini döndüren metodu yazınız.
        //int,double tiplerinde veri alabilsin(method overloading)


        //static double fakt(double k)
        //{
        //    Console.WriteLine($"k = {k}");
        //    double carpim = 1;
        //    for (double i= 1.0; i<= k;i++ )
        //    {
        //        carpim*= i;
        //    }
        //        return carpim;
        //}

        //Parametre olarak aldığı sayının asal olup olmadığını döndüren metod. 
        //Asal ise true değil ise false döndürsün.
        //static bool isPrime(int sayi)
        //{
        //   // bool prime = false;

        //    for(int i= 2; i<sayi ;  i++)
        //    {
        //        if(sayi%i==0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}


        //Rastgele ürettiği 10 sayıyı int tipinde dizi olarak döndüren metodu tanımlayınız.

        //static int[] Random10()
        //{
        //    int[] sayiDizisi = new int[10];
        //    Random r = new Random();
        //    for (int i = 0; i<10;i++)
        //    {
        //        sayiDizisi[i] = r.Next(100);
        //    }
        //    return sayiDizisi;
        //}


        //Kendisine parametre olarak gönderilen int dizinin elemanlarını ekrana yazdıran metod.



        //kendisine gönderilen dizideki tekSayilari yine dizi ile döndüren metodu yazınız.(limit 20 : eleman sayısı)

        //static int[] dizitek(int[] sayiDizisi)
        //{
        //    int[] teklerdizisi = new int[20];


        //    for (int i = 0; i < sayiDizisi.Length ; i++)
        //    {

        //        if (sayiDizisi[i] % 2 == 1)
        //            teklerdizisi[i] = sayiDizisi[i];
        //    }
        //    return sayiDizisi;
        //}


        //parametre olarak aldığı 2 adet sayıdan büyük olanı döndüren metodu yazınız.

        //static int[] buyuksayi(int s1,int s2)
        //{
        //    if (s1 > s2)
        //        return s1;
        //    else if (s2 > s1)
        //        return s2;
        //    else
        //        return s1;
        //}

        //parametre olarak aldığı 3 adet sayıdan büyük olanı döndüren metodu yazınız.

        //static int[] buyuksayi(int s1, int s2,int s3)
        //{
        //    if (s1 > s2 && s1> s3)
        //        return s1;
        //    else if (s2 > s1 && s2>s3)
        //        return s2;
        //    else if (s3>s1 && s3>s1)
        //        return s3;


        //    ///OR////
        //    ///

        //    return
        //}



        //List tipinde aldığı 10 adet sayının karelerini List tipinde döndüren metod
        //(2 tane list olacak)

        //static List<int> listeKare(List<int> sayilar)
        //{
        //    listeKare<int kareler = new List<int>();
        //    int boyut = sayilar.Count();
        //    for(int i = 0; i<boyut ;i++)
        //    {
        //        kareler.Add(sayilar[i] * sayilar[i]);
        //    }
        //    return kareler;
        //}

        ////Liste sorusu: Kullanıcıdan 10 sayi alıp liste ile döndüren metod.
        //static List<int> sayiGetir10()
        //{

        //    List<int> sayilar = new List<int>();


        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine($"{i}.sayı = ");
        //        int sayi = int.Parse(Console.ReadLine());
        //        sayilar.Add(sayi);

        //    }
        //    return sayilar;

        //}

        //(enKucuk,enBuyuk,sayiAdedi)
        // enKucuk ile enBuyuk arasında sayi adedince rastgele sayi üretsin
        //Bir Listeye atıp döndürsün

        //static List<int> sayiuret(int enKucuk,int enBuyuk,int sayiAdedi)
        //{
        //    List<int> sayilar = new List<int>();

        //    Random r = new Random();
        //    for (int i = 0; i < sayiAdedi; i++)
        //    {
        //        int sayi = r.Next(enKucuk, enBuyuk);
        //        sayilar.Add(sayi);
        //    }
        //    return sayilar;
        //}




        //KKendisine liste olarak gönderilen stringlerin tek bir string olarak birleştirilip
        //döndüren metodu yazınız.
        //List<string> => Metotda parametre olarak gönder.
        //string olarak al.

        //List<string> kelimelerim = new List<string>() { "araba", "hızla", "yanımdan", "geçti" };

        static string listToString(List<string> yazilar)
        {

        }



    }
}
