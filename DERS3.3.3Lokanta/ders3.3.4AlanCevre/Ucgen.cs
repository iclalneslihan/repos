using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders3._3._4AlanCevre
{
    class Ucgen : Sekil
    {
        public Ucgen()
        {
            this._AlanHesapla = h * taban;
            this._CevreHesapla = kenar1 + kenar2 + kenar3
        }
        public override void AlanHesapla()
        {
            Console.WriteLine($"Üçgenin alanı: {this._AlanHesapla}");
        }
        public override void CevreHesapla()
        {
            Console.WriteLine($"Üçgenin çevresi: {this._CevreHesapla}");
        }
    }
}
