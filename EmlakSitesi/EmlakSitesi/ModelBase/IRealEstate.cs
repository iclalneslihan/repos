using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.ModelBase
{
    public enum SellType
    {
        ForSale,
        ForRent
    }
    interface IRealEstate
    {
        int ID { get; set; }
        SellType _SellType { get; set; }
        double Square { get; set; }
        Address _Address { get; set; }
    }
}
