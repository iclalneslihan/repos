using Alisveris.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alisveris.Entity
{
    [Table(PrimaryColumn = "ID", TableName = "ad", IdendityColumn = "ID")]
    public class Siparis
    {
        public int ID { get; set; }
        public int SepetID { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public double ToplamTutar { get; set; }
    }
}
