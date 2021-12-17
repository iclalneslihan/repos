using System;

namespace Ders9_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Derslik isimli sınıfı aşağıdaki özellikler ve metotlar ile tanımlayınız.
            //Bu senaryo: 1 öğretmenin 1 sınıfı var. 1 öğretmen 1 derslikte ders işler.
            //Dersliğin öğretmeni olsun.

            //properties: derslikN, adi, kapasite, kat, ogretmen
            //derslikAtamaKontrol(Ogretmen) => bool: Öğretmenin öğrenci sayısı sınıf kapasitesine
            //sığıyorsa true yoksa false
            //derslikAta(Ogretmen) => Öğretmenin dersliği değiştiriliyor.

            Ogretmen ogretmen1 = new Ogretmen();
            ogretmen1.ad = "Mustafa";
            ogretmen1.soyad = "Kılıç";

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.ad = "Aysel";
            ogrenci1.soyad = "Demir";
            ogrenci1.sinifOgretmeni = ogretmen1; // öğrencinin öğretmenini belirledik.


            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.ad = "Mahir";
            ogrenci2.soyad = "Demir";
            ogrenci2.sinifOgretmeni = ogretmen1; // öğrencinin öğretmenini belirledik.


            Ogrenci ogrenci3 = new Ogrenci();
            ogrenci3.ad = "Sevim";
            ogrenci3.soyad = "Demir";
            ogrenci3.sinifOgretmeni = ogretmen1; // öğrencinin öğretmenini belirledik.



            ogretmen1.ogrenciler.Add(ogrenci1); // öğretmenin listesine öğrenciyi ekledik.
            ogretmen1.ogrenciler.Add(ogrenci2); // öğretmenin listesine öğrenciyi ekledik.
            ogretmen1.ogrenciler.Add(ogrenci3); // öğretmenin listesine öğrenciyi ekledik.

            Derslik d203 = new Derslik();
            d203.kapasite = 15;
            d203.kat = 2;

            d203.OgretmenAta(ogretmen1);
            d203.BilgiYaz();


        }
    }
}
