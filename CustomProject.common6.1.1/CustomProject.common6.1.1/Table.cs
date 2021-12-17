using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProject.common6._1._1
{
    interface Table:Attribute
    {
        public string TableName { get; set; }
        public string PrimaryColumn { get; set; }

    }
}
