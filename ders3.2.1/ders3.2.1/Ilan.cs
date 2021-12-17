using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders3._2._1
{
    class Ilan
    {
        private string ılanNo;
        private string baslik;
        private DateTime ılanTarihi;
        private string kategori;
        private float fiyat;
        private Kullanici satici;

        public string IlanNo { get => ılanNo; set => ılanNo = value; }
        public string Baslik { get => baslik; set => baslik = value; }
        public DateTime IlanTarihi { get => ılanTarihi; set => ılanTarihi = value; }
        public string Kategori { get => kategori; set => kategori = value; }
        public float Fiyat { get => fiyat; set => fiyat = value; }
        internal Kullanici Satici { get => satici; set => satici = value; }


        public void IndirimYap(byte indirimOrani)
        {
            this.Fiyat = this.Fiyat - (this.Fiyat * (indirimOrani / 100));
            // Fİyat indirim oranına göre güncellendi.
            Console.WriteLine($"Fiyat %{indirimOrani} düşürüldü. Güncel fiyat: {this.Fiyat}");
        }

        public void BilgiYaz()
        {
            Console.WriteLine($"Ilan Numarası: {this.IlanN}");
            Console.WriteLine($"Baslık: {this.Baslık}");
            Console.WriteLine($"IlanTarihi: {this.IlanTarihi}");
            Console.WriteLine($"Kategori: {this.Kategori}");
            Console.WriteLine($"Fiyat: {this.Fiyat}");
            Console.WriteLine();
            Console.WriteLine($"*******SATICI BİLGİLERİ*******");
            Console.WriteLine($"Satici: {this.Satici.adSoyad}");

        }
    }


}
