using Alisveris.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alisveris.Entity
{
    [Table(PrimaryColumn = "ID", TableName = "ad", IdendityColumn = "ID")]
    public class SepetItem
    {
        public int ID { get; set; }
        public int UrunID { get; set; }
        public int KullaniciID { get; set; }
        public int SepetID { get; set; }
        public double araToplam { get; set; }

    }
}
