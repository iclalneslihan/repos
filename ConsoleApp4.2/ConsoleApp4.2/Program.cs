using System;

namespace ConsoleApp4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //// ÖR:Klavyeden girilen sayıya kadar olan çift sayıları yazan prog.

            //int s = Convert.ToInt32(Console.ReadLine());

            //for( int i=1;i< s; i++)
            //{   if(i%2 == 0)
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Program sonlandı.");




            //AZALAN OLSAYDI:
            //Console.Write("Sayı=");
            //int s = Convert.ToInt32(Console.ReadLine());

            //for (int i = s; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}
            //Console.WriteLine("Program sonlandı.");



            //ÖR:girilen 2 sayı arasındaki sayıları azalan şekilde yazan
            //büyük ve küçük sayıyı sırasız girebilecek

            //    Console.Write("Sayı1=");
            //    int s1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Sayı2=");
            //    int s2 = Convert.ToInt32(Console.ReadLine());
            //    int i;

            //    if (s1 < s2)
            //    {

            //        for (i = s2; i >= s1; i--)
            //        {

            //            Console.WriteLine(i);
            //        }
            //    }

            //    else if (s1 > s2)
            //    {
            //        for (i = s1; i >= s2; i--)
            //        {

            //            Console.WriteLine(i);
            //        }
            //    }
            //    Console.WriteLine("Program sonlandı.");


            //}

            //ÖR: Marketteki her ürünün fiyatının tek tek girilip her biri için %18 KDV'li fiyatını ekrana yazdıran prog.
            // Tüm ürünlerin toplam fiyatını kdv dahil olarak ekrana yazdıran program. 5 ürün
            // 100 ise 118


            double t=0;
            double urun;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("urun=");
                urun = Convert.ToInt32(Console.ReadLine());

                urun = urun + (urun * 0.18);
                t += urun;

            }
            Console.WriteLine(t);

        }
    }

}