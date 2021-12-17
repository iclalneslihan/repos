using Alisveris.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alisveris.Entity
{
    [Table(PrimaryColumn = "ID", TableName = "ad", IdendityColumn = "ID")]
    public class Urun
    {
        public int ID { get; set; }
        public string ad { get; set; }
        public double fiyat { get; set; }
        public Kategori Kategori { get; set; }
        //public int SaticiID { get; set; }
        public Satici Satici { get; set; }
        public Degerlendirme Degerlendirme { get; set; }
    }
}
