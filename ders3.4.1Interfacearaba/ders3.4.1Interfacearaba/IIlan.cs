using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders3._4._1Interfacearaba
{
    interface IIlan
    {
        long IlanN { get; set; }
        DateTime IlanTarihi { get; set; }

        Kullanici Satici { get; set; }
   
    }
}
