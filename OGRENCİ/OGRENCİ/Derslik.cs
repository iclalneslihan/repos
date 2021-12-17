using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders9_OOP1
{
    class Derslik
    {
        public int derslikN;
        public string adi;
        public byte kapasite;
        public byte kat;
        public Ogretmen ogretmen;

        private bool OgretmenAtamaKontrol(Ogretmen ogretmen)
        {
            int ogrenciSayisi = ogretmen.ogrenciler.Count();
            if (ogrenciSayisi <= this.kapasite) // öğretmenin öğrenci sayısı sınıfın kapasitesinwe uygun mu?
                return true;
            else
                return false;
        }

        public bool OgretmenAta(Ogretmen ogretmen)
        {
            bool kontrol = this.OgretmenAtamaKontrol(ogretmen);
            if (kontrol == true)
            {
                this.ogretmen = ogretmen;
                Console.WriteLine($"{ogretmen.ad + " " + ogretmen.soyad} ataması başarılı! ");
                return true;
            }
            else
            {
                Console.WriteLine("Atama başarısız. Sınıf kapasitesi yetersiz!!!");
                return false;
            }
        }

        public void BilgiYaz()
        {
            Console.WriteLine($" ******  {this.adi} SINIFI BİLGİLERİ ****** ");
            Console.WriteLine($"Kapasite : {this.kapasite}");
            Console.WriteLine($"KAT : {this.kat}");
            Console.WriteLine($"Sınıf Öğretmeni: {this.ogretmen.ad + " " + this.ogretmen.soyad}");
            Console.WriteLine($"Kullanılan Kapasite : {this.ogretmen.ogrenciler.Count()}");
        }

    }
}
