using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders3._2._1
{
    class Bilgisayar: Ilan
    {
        private string marka;
        private string ıslemci;
        private double bellek;
        private string HDD;
        private string SSD;
        private bool ethernetVarWifi;
        private bool wifiVarMi;

        public string Marka { get => marka; set => marka = value; }
        public string Islemci { get => ıslemci; set => ıslemci = value; }
        public double Bellek { get => bellek; set => bellek = value; }
        public string HDD1 { get => this.HDD; set => this.HDD = value; }
        public string SSD1 { get => SSD; set => SSD = value; }
        public bool EthernetVarWifi { get => ethernetVarWifi; set => ethernetVarWifi = value; }
        public bool WifiVarMi { get => wifiVarMi; set => wifiVarMi = value; }
      
    }
}
