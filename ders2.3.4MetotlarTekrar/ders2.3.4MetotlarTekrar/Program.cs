using System;
using System.Collections.Generic;

namespace ders2._3._4MetotlarTekrar
{
    class Program
    {
        static List<long> TCler = new List<long>();
        static List<string> adSoyadlar = new List<string>();
        static List<string> adresler = new List<string>();
        static List<string> telefonlar = new List<string>();
        static void Main(string[] args)
        {



            //AlanCevreD(5, 10);


            //Yaz(yazi);


            ////5 yazı girilsin.Ekrana girilenleri yazalım.
            //List<string> gelenYazilar = CokYaz(5);
            //for (int i = 0; i < gelenYazilar.Count(); i++)
            //{
            //    Console.WriteLine(gelenYazilar[i]);
            //}


            PersonelEkle(546, "Mehmet Demir", "istanbul", "0546..");
            //PersonelSil(546);
            //PersonelGüncelle(tc: 546, adsoyad: "Ahmet Demir");
            //PersonelAra(ad: "Ahmet Demir");

            //Listeleri yazdırırsan.


        }




        //Parametre olarak aldığı kısa kenar ve uzun kenar bilgisi ile dikdörtgenin alan ve çevresini hesaplayıp ekrana yazdıran motod
        //AlanCevreD

        //static void AlanCevreD(int kk, int uk)
        //{
        //    int cevre = 2 * (kk + uk);
        //    int alan = kk * uk;
        //    Console.WriteLine($"Dikdörtgen alanı= {alan}, çevresi = { cevre}");

        //}

        //1.metot tanımlıyoruz: 1.si kullanıcıdan veri girişi
        //alan : string. Yaz() kullanıcıdan alınan yazıyı döndürecek.
        //dönüş tipi string.parametre yok

        //static string Yaz(string yazi);
        //{
        //    Console.Write("yaz : ");
        //    return Console.ReadLine();
             

        //}




        //2.metot cokYaz(int adet) adet sayısının aldığı string değerleri bir liste ile döndürecek.
        //(Yaz metodu ile kullanıcıdan string alınıp listeye atılacak)


    //    static List<string> CokYaz(int yaziAdedi)
    //{
    //    List<string> yazilar = new List<string>();

    //    for(int i =0;i<yaziAdedi;i++)
    //    {
    //        yazilar.Add(Yaz());
    //    }
    //    return yazilar;
    //}



    //Öğrenci Bilgi Sistemi yapıyoruz.
    //TC(long)  ,AdSoyad(string)   ,Adres(string)    ,Telefon(string)
    //için bir veya birer tane liste tanımlıyoruz.
    //Methotlar :
    //PersonelEkle(gerekli parametreleri alıp ekleme yapacak.başarılı olarak ekleyince true döndürecek)
    //PersonelSil(TC): TC kimlik numarası alınan personel listeden silinecek.
    //PersonelGuncelle: tc hariç tüm bilgileri opsiyonel olarak alıp güncelleme yapacak.(tc+ güncellenecek bilgiler)
    //Personelin eski ve yeni bilgisi string ile alt alta birleştirilerek döndürülsün
    //PersonelAra( herhangi bir parametre ilr arama yapılacak.
    //Personelin tüm bilgileri string olarak döndürülsün.


    static bool PersonelEkle(long tc, string adsoyad, string adres, string telefon)
    {

        TCler.Add(tc);
        adSoyadlar.Add(adsoyad);
        adresler.Add(adres);
        telefonlar.Add(telefon);

            return true;

    }

        static string PersonelAra(long tc = 0, string adsoyad = "")
        {
            static personel = "";

            if (adsoyad != "")
            {
                if(adSoyadlar.Contains(adsoyad)==true)
                {
                    personelIndex = adSoyadlar.IndexOf(adsoyad);
                   // PersonelAra += Convert.ToString(TCler[personelIndex]);
                }
                
                //adsoyad ile arama yap.
            }
            else if (tc != 0)
                {
                //tc ile ara
            }
            if()
            {

            }
        }

        //static string PersonelSil()
        //{

        //}

        //static string PersonelGüncelle()
        //{

        //}


    }
}

