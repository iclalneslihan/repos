using System;

namespace ConsoleApp2._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ÖR2:
            double[] doubleArrayExp = { 5.0, 4.5, 6.5, 7.9 };
            makeItFloat(doubleArrayExp);

        }


            //ÖR1: Kullanıcıdan 2 sayı alıp 1 işlem alıp sonucu döndüren metodu tanımlayınız.
            //(s1,s2,string)

        //static int Hesapla(int s1,int s2,string islem)
        //{
        //    Console.WriteLine($"s1 = {s1}");
        //    Console.WriteLine($"s2 = {s2}");
        //    Console.WriteLine($"işlem = {islem}");
        //    int islem = 0;

        //    if (islem.ToLower() == "topla")
        //    { 
        //   sonuc = s1 + s2;
        //    return sonuc;
        //    }
        //    else if (islem.ToLower() == "çıkar")
        //    {
        //        sonuc = s1 - s2;
        //    return sonuc;
        //    }
        //    else if (islem.ToLower() == "çarp")
        //    {
        //        sonuc = s1 * s2;
        //    return sonuc;
        //    }
        //    else if (islem.ToLower() == "böl")
        //    {
        //        sonuc = s1 / s2;
        //    return sonuc;
        //    }
        //}

        //ÖR2:Kendisine gönderilen float dizisini çeviren makeItDouble isimli metodu tanımlayınız.
        //10 elemanlı bir dizi.


        static float[] makeItFloat (double[] doubleArray)
        {
            float[] floatArray = new float[doubleArray.Length];
                for(int i = 0;i< doubleArray.Length;i++)
            {
                floatArray[i] = (float)doubleArray[i];
            }
                foreach (var item in floatArray)
            {
                Console.WriteLine(item);
            }
            return floatArray;
        }




    }
}
