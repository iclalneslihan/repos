using Alisveris.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alisveris.Entity
{
     // Veri tabanındaki tablo karşılığı ve bu tablodaki primary key kolonunu belirttik.

        [Table(PrimaryColumn = "ID", TableName = "ad", IdendityColumn = "ID")]
        public class Kategori
        {
            public int ID { get; set; }
            public string ad { get; set; }

        }
    
}
