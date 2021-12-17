using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alisveris.common;

namespace Alisveris.Entity
{
    [Table(PrimaryColumn = "ID", TableName = "ad", IdendityColumn = "ID")]
    public class Degerlendirme
    {
        public int ID { get; set; }
        public int KullaniciID { get; set; }
        public int Yildiz { get; set; }
        public string Yorum { get; set; }
     
    }
}
