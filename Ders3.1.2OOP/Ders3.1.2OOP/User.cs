using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3._1._2OOP
{
    class User
    {
        private int ID;
        private string adSoyad;
        private string telefon;

        public int ID { get => ID; set => ID = value; }
        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public string Telefon { get => telefon; set => telefon = value; }
    }
}
