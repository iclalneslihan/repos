using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3._4._1INTERFACE
{
    enum Kategori { Otomobil, Emlak, Beyaz_Esya, Mobilya}
    interface ISablon2
    {
        string ID { get; set; }
        double Fiyat { get; set; }
        Kategori Kategori { get; set; }

        double GetFiyat();
    }
}
