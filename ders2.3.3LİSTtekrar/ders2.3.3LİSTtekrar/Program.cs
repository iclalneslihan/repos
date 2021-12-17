using System;

namespace ders2._3._3LİSTtekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> liste = new List<int>();
            //liste.Add(14);
            //liste.Insert(1, 34);

            //Console.WriteLine(liste[0]);

            //forech(var item in liste)
            //    { 
            //    Console.WriteLine(item);
            //    }

            //liste.clear();

            //List<string> sehirler = new 




            //ÖR1: Kullanıcıdan 5 isim alıp bunları sıralayıp ekrana yazdıran programı yazınız.
            //



            List<string> isimler = new List<string>();
            
            for(int i =0;i < 5 ;i++)
            {
                Console.Write("isim : ");
                string isim = Console.ReadLine();
                isimler.Add(Console.ReadLine());
            }

            isimler.Sort();
            foreach(var isim in isimler)
            {
                Console.WriteLine(isim);
            }



            //Farklı tipte verileri tutmak için
            List<object> karisikListe new List<object>...........







        }
    }
}
