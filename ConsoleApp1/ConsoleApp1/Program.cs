using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Notu gir: ");
            //int not = Convert.ToInt32(Console.ReadLine());

            //if (not >= 0 && not <= 49)
            // Console.WriteLine($"Notunuz F"); 
            //else if (not >= 50 && not <= 64)
            // Console.WriteLine($"Notunuz D"); 
            //else if (not >= 65 && not <= 69)
            // Console.WriteLine($"Notunuz C"); 
            //else if (not >= 70 && not <= 84)
            // Console.WriteLine($"Notunuz B"); 
            //else if (not >= 85 && not <= 100)
            //Console.WriteLine($"Notunuz A"); 
            //else
            //    Console.WriteLine("HATALI NOT");


            //Console.WriteLine("sayi1: ");
            //float sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("sayi2: ");
            //float sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ISLEM: ");
            //string islem = Console.ReadLine();

            //if (islem == "topla")
            // Console.WriteLine($"Toplamı: {sayi1 + sayi2}"); 
            //else if (islem == "cikar")
            // Console.WriteLine(( sayi1 - sayi2)); 
            //else if (islem == "carp")
            //Console.WriteLine(( sayi1 * sayi2));
            //else if (islem == "bol")
            //    Console.WriteLine(( sayi1/sayi2));
            //else 
            //    Console.WriteLine( "Hatalı işlem girdiniz!");

            //ÖR: Klavyeden girilen sayı çift ise ekrana yazdırsın.
            //    tek ise 3 ün katı mı değil mi kontrol edilsin
            //    3 ün katı ile kaç katı olduğu ekrana yazdırılsın.



            // Console.WriteLine("sayi: ");
            // float sayi = Convert.ToInt32(Console.ReadLine());


            // if (sayi % 2 == 0)
            //     Console.WriteLine($"ÇİFT");
            // else
            // {
            //     if (sayi % 3 == 0)



            //}

            // ÖR: Klavyeden girilen 5 sayıdan kaçının pozitif kaçının negatif olduğunu
            // sayan ayrıca negatifler toplamı ve pozitifler toplamını ekrana yazdıran prog.
            // 1. aşama toplamları ekrana yazdır.
            // 2. aşama kaç negatif kaç pozitif?



            //            Console.WriteLine("sayi1: ");
            //            int sayi1 = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("sayi2: ");
            //            int sayi2 = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("sayi3: ");
            //            int sayi3 = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("sayi4: ");
            //            int sayi4 = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("sayi5: ");
            //            int sayi5 = Convert.ToInt32(Console.ReadLine());
            //            int NT=0;
            //            int PT=0;
            //            int NS= 0;
            //            int PS= 0;


            //            if (sayi1 < 0)
            //            { 
            //                NT += sayi1;
            //                NS += 1;
            //            }
            //            else if (sayi1 > 0)
            //            { 
            //                PT += sayi1;
            //            PS += 1;
            //             }
            //            if (sayi2 < 0)
            //            { 
            //                NT += sayi2;
            //            NS += 1;
            //}
            //            else if (sayi2 > 0)
            //            { 
            //                PT += sayi2;
            //            PS += 1;
            //}
            //            if (sayi3 < 0)
            //            { 
            //                NT += sayi3;
            //            NS += 1;}
            //            else if (sayi3 > 0)
            //            { 
            //                PT += sayi3;
            //            PS += 1;}

            //            if (sayi4 < 0) { 
            //                NT += sayi4;
            //            NS += 1;}
            //            else if (sayi4 > 0)
            //            {
            //                PT += sayi4;
            //            PS += 1; }

            //            if (sayi5 < 0) { 
            //                NT += sayi5;
            //            NS += 1;}
            //            else if (sayi5 > 0)
            //            { 
            //                PT += sayi5;
            //            PS += 1;}

            //            Console.WriteLine($"NT: {NT} , NS: {NS}");
            //            Console.WriteLine($"PT: {PT} , PS: {PS}");


            //Rakamları ekrana yazdıran prog.

            //    int rakam = 0;
            //Etiket:
            //    Console.WriteLine(rakam);
            //    rakam++;
            //    if (rakam < 10)
            //        goto Etiket;


            //    Console.WriteLine("sayi: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    int Fakt = 1;
            //Etiket:

            //    Fakt= Fakt* sayi;
            //    sayi--;
            //    if (sayi >= 1)
            //        goto Etiket;
            //    Console.WriteLine(Fakt);


            //Formül kullanmadan:
            // Klavyeden taban ve üst bilgisi alın, tabanın üs bilgisine göre kuvvetini hesaplayın.


            //    Console.WriteLine("taban: ");
            //    int taban = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("kuvvet: ");
            //    int kuvvet = Convert.ToInt32(Console.ReadLine());
            //    int sonuc = 1 ;


            //Label:
            //    if (kuvvet > 0)
            //    {
            //        sonuc *= taban;
            //        kuvvet--;
            //        goto Label;
            //    }

            //    else
            //    {
            //        Console.WriteLine(sonuc);
            //    }



            //ÖR: Klavyeden girilen sayı 0-100 arasında değilse tekrar isteyen prog yaz.
            // Yukarıdaki şekilde 3 sayı alıp bunların aitmatik ortalamasını bulan pog.

            Console.WriteLine("sayi: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("sayı2: ");
            //int sayı2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("sayı3: ");
            //int sayı3 = Convert.ToInt32(Console.ReadLine());
            //int AO = 0;
            int T = 0;
            int i = 1;
            


        Label:

            Console.WriteLine("sayi: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (100 >= sayi && sayi >= 0  )
            {

                goto Label;
            }
            ????????????????????
            else if (i<=3)
            {
                T += sayi;
                i++;

                
            }
             Console.WriteLine($"Aralıkta sayı gir");
            Console.WriteLine($"Aritmatik Ortalama: (T/3)");














        }
    }
}
