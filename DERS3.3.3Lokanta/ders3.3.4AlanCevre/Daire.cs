using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders3._3._4AlanCevre
{
    class Daire
    {
        public Daire()
        {
            this._AlanHesapla = pi * (r*r) ;
            this._CevreHesapla = 2 * pi*r;
        }
        public override void AlanHesapla()
        {
            Console.WriteLine($"Dairenin alanı: {this._AlanHesapla}");
        }
        public override void CevreHesapla()
        {
            Console.WriteLine($"Dairenin çevresi: {this._CevreHesapla}");
        }
    }
}
