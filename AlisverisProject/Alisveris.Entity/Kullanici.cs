using Alisveris.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alisveris.Entity
{
    [Table(PrimaryColumn = "ID", TableName = "ad", IdendityColumn = "ID")]
    public class Kullanici
    {
        public int ID { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string adres { get; set; }
        public int sepetID { get; set; }

    }
}
