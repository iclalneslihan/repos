using System;

namespace ders2._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Topla(4, 5));
            //Console.WriteLine(Topla(4, 5,5,6,7));
            //Console.WriteLine(Topla(4, 5,12,13,14));


            //Console.WriteLine(PuanTopla("Mehmet", 33, 50, 40, 20, 30));
            //Console.WriteLine(PuanTopla("Engin", 35, 45, 56));

            int f4 = Faktoriyel(4);
            Console.WriteLine(f4);


        }

        static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach(int sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }

        //Recursive: Kendini tekrar eden veya çağıran metotlar
        static int Faktoriyel(int sayi)
        {
            if (sayi <= 1)
                return 1;
            else
                return sayi * Faktoriyel(sayi - 1);
        }




    }
}
