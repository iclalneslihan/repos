using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3._1._2OOP
{
    class Rent
    {
        private int ID;
        private string bisiklet;
        private string kullanici;
        private float sure;
        private float Ucret;
        private DateTime BaslamaZamani;
        private DateTime BitisZamani;
        private float DakikaUcret;

        
        public int ID1 { get => this.ID; set => this.ID = value; }
        public string Bisiklet1 { get => bisiklet; set => bisiklet = value; }
        public string Kullanici1 { get => kullanici; set => kullanici = value; }
        public float Sure1 { get => sure; set => sure = value; }
        public float Ucret2 { get => Ucret; set => Ucret = value; }
        public DateTime BaslamaZamani2 { get => BaslamaZamani; set => BaslamaZamani = value; }
        public DateTime BitisZamani2 { get => BitisZamani; set => BitisZamani = value; }
        public float DakikaUcret2 { get => DakikaUcret; set => DakikaUcret = value; }


        //Metotlar: 
        //   KiralamaBaslat() => BaşlamaZamanini tut.

        //   KiralamaBitir() => BitisZamanini tut.

        //   UcretHesapla() => Bitis ve başlangıç arasındaki farkı tutup ücreti hesaplayıp döndürecek.(double)

        //   BilgiYaz() => Şu zamanda başladınız bu zamanda bitirdiniz.
        //   Toplam...dakika kullandınız.Ödemen, z gereken ücret...liradır.


        public void KiralamaBaslat()
        {

            this.BaslamaZamani = DateTime.Now;
            Console.WriteLine(this.BaslamaZamani);
        }
        public void KiralamaBitir()
        {
            this.BitisZamani = DateTime.Now;
        Console.WriteLine(this.BitisZamani);
            }
         public float UcretHesapla()
         {
            TimeSpan fark = this.BitisZamani - this.BaslamaZamani;
            this.sure = fark.Seconds;
            this.DakikaUcret = 0.25f;
            this.Ucret = this.DakikaUcret * this.sure;
            return this.Ucret;
        }
          public void BilgiYaz()
          {
             Console.WriteLine($"Sayın {this.User.adSoyad}; \nBaslama zamanı : {this.BaslamaZamani} \n Bitis zamanı {this.BitisZamani}\n Toplam süre: {this.sure}");
             Console.WriteLine($"Ücret :{this.Ucret}");
           }
        }
    }
}
