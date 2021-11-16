using System;
using System.Linq;

namespace ConsoleApp5._1
{
    class Program
    {
        static void Main(string[] args)
        {

            ////2.SORU/////
            ///

            //string satirlar = "";
            //while()
            //{
            //    Console.Write("yaz dostum: ");
            //    string satir = Console.ReadLine();
            //    if (satir.ToLower() == "çık")
            //    {
            //        Console.WriteLine($"Girilen değerler : (satirlar)");
            //        break;
            //    }
            //    else
            //        satirlar += satir + "\n";




            /////3.SORU////
            /////
            //int toplam = 0;
            //for(int i=1;i<=10;i++)
            //{
            //    int aratoplam = 1;
            //    for(int j=i;j>=1; j--)
            //    {
            //        aratoplam *=j;
            //    }
            //    toplam += aratoplam;
            //    Console.WriteLine($"{i} sayısının faktöriyeli = {aratoplam}");

            //}
            //Console.WriteLine($"Tüm sayıların faktöriyellerinin toplamı = {toplam}");


            ////DİZİLER

            //tip[] diziİsmi = new tip[boyut];
            //int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ////indis numaraları 0'dan başlar 1 er 1 er artarak devam eder.
            //Console.WriteLine($"ralkamlar dizisinin ilk elemanı : {rakamlar[0]}");
            //Console.WriteLine($"ralkamlar dizisinin 6. elemanı : {rakamlar[5]}");
            //rakamlar[0] = 100;
            //rakamlar.SetValue(100, 0); //yukarıdaki işlemi böyle de yapabiliriz.
            //Console.WriteLine(rakamlar[0]);

            //string[] sehirler = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya" };
            //Console.WriteLine(sehirler);
            //for (int i = 0; i < sehirler[i]) ;
            //{
            //    Console.WriteLine(sehirler[i]);
            //}
            //foreach(var sehir in sehirler)  // sehirler dizisindeki her bir sehir için...
            //{
            //    Console.WriteLine(sehir);
            //}

            //Kullanıcıdan alınan 10 adet isim bilgisini string bir diziye kaydedip,
            // daha sonra dizi elemanları ekrana yazdırın.


            //string[] isimler = new string[10];

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //Console.WriteLine("İsim: ");
            //isimler[i] = Console.ReadLine();

            //}
            //foreach (var isim in isimler)  
            //{
            //    Console.WriteLine(isim);
            //}

            ////ÖR:

            ////int[]puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30 };
            ////int indis10 = Array.IndexOf(puanlar, 10, 5);
            ////Console.WriteLine(indis10);
            ////Array.Sort(puanlar);

            //object[] karisikDizi = new object[10];
            //karisikDizi[0] = 10;
            //karisikDizi[0] = "Ayse";
            //karisikDizi[0] = 15.4F;
            //karisikDizi[0] = 15.80;


            ////0-100 arasında rastgele 10 sayı üretip bir diziye atın ve son olarak diziyi ekrana yazdırın.

            //Random rastgele = new Random();
            //Console.WriteLine(rastgele.Next(0, 100));
            ////devamı vardı yazmadım

            //int[] puanlar = { 10, 20, 30, 40, 14, 10, 20, 30 };
            //int indis100 = Array.IndexOf(puanlar, 10, 0); //0
            //int indis101 =Array.IndexOf(puanlar,10,1);//4
            //int indis101 = Array.IndexOf(puanlar, 10, 5);//6
            //Console.WriteLine(indis100);

            //int adet10 = puanlar.Count(sayi => sayı == 10);
            //Console.WriteLine($"dizide {adet10} tane 10 değeri var.");


            ////dizideki 10 değerlerinin index numaralarını ekrana yazdırın.For döngüsü ile


            //int[] scors = { 10, 20, 30, 40, 14, 10, 20, 30 };
            //int startIndex = 0;
            //int count10 = scors.Count(sayi => sayi == 10);

            //for (int i=0; i < count10;i++)
            //{
            //    startIndex = Array.IndexOf(scors, 10, startIndex);
            //    Console.WriteLine($"10 değeri {startIndex}. indexte var.");
            //    startIndex +=1;

            //}
            //int bulunmayanEleman = Array.IndexOf(scors, 100);
            //Console.WriteLine(bulunmayanEleman);


            //dizi1 'i dizi2'ye 0.indisten itibaren kopyala.

            //hoca yazdı notlardan bak.

            //////ÇOK BOYUTLU DİZİLER////

            //int[,] matris = new int[5, 5];
            //matris[0, 0] = 10;
            //matris[0, 4] = 20;
            //matris[4, 4] = 30;

            //for (int i=0; i<5;i++)
            //{
            //    for(int j=0;j<5;j++)
            //    {
            //        Console.Write(matris[i.j] + " ");
            //    }
            //    Console.WriteLine();
            //}







            /*
             2 0 0 0 2
             1 0 0 0 1
             2 0 0 0 1
             1 0 0 0 1
             2 0 0 0 2

            Bu çıktıyı veren matrisi döngü ile oluşturunuz.
             */

            //int[,] matris = new int[5, 5];


            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (i % 2 == 0 && (j == 0 || j == 4))
            //        {
            //            matris[i, j] = 2;

            //        }
            //        else if (j % 2 == 0 && (j == 0 || j == 4))
            //        {
            //            matris[i, j] = 1;

            //        }
            //    }

            //    for (int i = 0; i < 5; i++)
            //    {
            //        for (int j = 0; j < 5; j++)
            //        {
            //            Console.Write(matris[i, j] + " ");

            //        }

            //        Console.WriteLine();
            //    }





            //int[,] matris = new int[5, 5];


            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (i == j || i + j == 4)
            //        {
            //            matris[i, j] = 1;

            //        }
            //    }
            //}
            //    for (int s = 0; s < 5; s++)
            //    {
            //        for (int k = 0; k < 5; k++)
            //        {
            //            Console.Write(matris[s, k] + "  ");

            //        }

            //        Console.WriteLine();
            //    }



            ////2X4 luk bir dizi tanımlayın.Bu dizinin her bir elemanı için klavyeden sayı alıp atayın
            //// 


            //int[,] matris = new int[2, 4];

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {   
            //        if(j!=3)
            //        { 
            //        Console.Write("Sayı: ");
            //        int sayi = Convert.ToInt32(Console.ReadLine());
            //        matris[i, j] = sayi; 
            //        }

            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    int satirtoplam = 0;

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matris[i, j] + "{satirtoplam} ");!!!!!!!!!!!!!!!!!!!!!!!
            //    }
            //    matris[i, 3] = satirtoplam;
            //}


            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(matris[i, j] + " ");

            //    }

            //    Console.WriteLine();
            //}


            //3 BOYUTLU DİZİ//


            Random rnd = new Random();
            int[,,] dizi3B = new int[2, 3, 3];

            for (int z = 0; z < 2; z++)  //3x3 lük diziler
            {
                for (int i = 0; i < 3; i++)  //satırlar
                {
                    for (int j = 0; j < 3; j++)   //sütunlar
                    {
                        dizi3B[z, i, j] = rnd.Next(1000);

                    }
                }
            }
            for (int z = 0; z < 2; z++)  //3x3 lük diziler
            {
                for (int i = 0; i < 3; i++)  //satırlar
                {
                    for (int j = 0; j < 3; j++)   //sütunlar
                    {
                        Console.WriteLine(dizi3B[z, i, j] + " ");

                    }
                    Console.WriteLine();
                }
                Console.WriteLine("********************");
                Console.WriteLine("********************");
            }
        }
    }
}
