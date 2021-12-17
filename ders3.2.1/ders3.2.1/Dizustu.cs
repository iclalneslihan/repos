using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders3._2._1
{
    class Dizustu: Bilgisayar
    {
        private float _EkranBoyutu;
        private int _Agırlık;

        public float EkranBoyutu { get => _EkranBoyutu; set => _EkranBoyutu = value; }
        public int Agırlık { get => _Agırlık; set => _Agırlık = value; }

        new public void BilgiYaz()
        {
            base.BilgiYaz();
            Concole.WriteLine($"Marka: {base.Marka}");
            Concole.WriteLine($"İşlemci: {base.Islemci}");
            Concole.WriteLine($"Bellek: {base.Bellek}");
            Concole.WriteLine($"HDD: {base.HDD}");
            Concole.WriteLine($"SSD: {base.SSD}");

            Concole.WriteLine($"Ethernet: {base.EthernetVarWifi}");
            Concole.WriteLine($"Wifi: {base.WifiVarMi}");
            string eth = "Yok";
            string wifi = "Yok";

        }
    }
}
