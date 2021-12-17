using System;

namespace ders2._4._3TRYCATCH
{
    class Program
    {
        static void Main(string[] args)
        {
            //int bolunen = 20;
            //int bolen = 0;

            //try
            //{ 
            //    int bolum = bolunen / bolen;
            //    Console.WriteLine(bolum);
            //}
            //catch(Exception)
            //{
            //    Console.WriteLine("Bir hata ile karşılaşıldı.Ancak program durmadı.devam ediyor.");

            //}
            catch (DivideByZeroException hata)
            {
                Console.WriteLine($"0'a bolme hatası")
            }

            //finally
            //{
            //    Console.WriteLine("Try daki blok çalışsada çalışmasada çalışan blok.2 durumda da çalışır.");
            //}
            //Console.WriteLine("Program bitti.");



            //Spesifik hata yakalama





        }
    }
}
