using System;

namespace _2._5._2NesneyeYP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Araba arabaNesnesi = new Araba();
            //arabaNesnesi.Marka = "Mazda";
            //arabaNesnesi.Model = "6";
            //arabaNesnesi.BilgiYaz();

            //Araba araba2 = new Araba();
            //araba2.Marka = "BMW";
            //araba2.Model = "XS";
            //araba2.BilgiYaz();
            //araba2 = null;

            //Araba araba3 = new Araba(1, "Mercedes", "S500");
            //araba3.BilgiYaz();

            Ogretmen ahmetogretmen = new Ogretmen();
            ahmetogretmen.ad = "Ahmet";
            ahmetogretmen.soyad = "";


            Ogrenci ogr = new Ogrenci(1234123123, "432", "Mehmet", "Demir", "Ahmet Güleli");
            mehmet.BilgiYaz();
            //mehmet.sinifOgretmeniDegistir("Selahattin ")













        }
    }

    //class Araba
    //{
    //    Int ID;
    //    public string Marka;
    //    public string Model;

    //    public Araba()
    //    {
         
    //    public Araba(int id, string marka, string model)
    //    {
    //        this.ID = id;
    //        this.Marka = marka;
    //        this.Model = model;
    //    }    public Araba(int id, string marka, string model, int year)
    //    {
    //        this.ID = id;
    //        this.Marka = marka;
    //        this.Model = model;
    //    }

    //    // YIKICI METOT: Destructor. Nesne bellekten silinmeden hemen önce çalışır.
    //    ~Araba()
    //    {
    //        // Veritabanı bağlantısı kontrolü:veritabanına kaydedilmemişse kaydet silmeden.
    //        // sql bağlantısını kapat.
    //        Console.WriteLine("Yıkıcı metot çalıştı.!!");
    //    }

    //    // Sınıf metotları
    //    public void BilgiYaz()
    //    {
    //        Console.WriteLine($"Marka : {this.Marka} "); // this anahtar kelimesi nesneyi temsil eder.
    //        Console.WriteLine($"Model : {this.Model} ");
    //    }

    //}
   Console.WriteLine("Yapıcı metot çalıştı!!!");
        }
    class student
    {
        //Öğrenci sınıfını aşağıadaki özellikler ve metotları ile tanımlayınız.
        //Properties :tcKimlikN, okulN, ad,soyad, sinifOgretmeni
        //Methods : SinifOgretmeniDegistir(string ogrtmn)
        //Methods : BilgiYaz(). Öğrencinin tüm bilgileri ekrana yazılsın.

        public long TC;
        public string okulNo;
        public string ad;
        public string soyad;
        //public string sinifOgretmeni;
        public Ogretmen ogretmen;

        public Ogrenci(long l, string okulNo, string ad , string soyad, string sinifOgretmeni)
        {
            this.TC = l;
            this.okulNo = okulNo;
            this.ad = ad;
            this.soyad = soyad;
            this.sinifOgretmeni = sinifOgretmeni;
        }


        public void sinifOgretmeniDegistir(string ogretmen)
        {

        }
    

     }










}
