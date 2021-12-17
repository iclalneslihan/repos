using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders3._4._1Interfacearaba
{
    class Kullanici
    {
        private string AdSoyad;
        private string Eposta;
        private string Telefon;

        public string AdSoyad1 { get => AdSoyad; set => AdSoyad = value; }
        public string Eposta1 { get => Eposta; set => Eposta = value; }
        public string Telefon1 { get => Telefon; set => Telefon = value; }

        public List<string> GetKullanici()
        {
            List<string> bilgiler = new List<string>();
            bilgiler.Add(this.AdSoyad);
            bilgiler.Add(this.Eposta);
            bilgiler.Add(this.Telefon);
            return;
        }

    }
}
