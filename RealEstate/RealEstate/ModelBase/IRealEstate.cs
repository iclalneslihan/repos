using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.Models;

namespace RealEstate.Models
{
    public enum SellType
    {
        ForSale,
        ForRent
    }
    interface IRealEstate
    {
        int RealEstateID { get; set; }
        SellType _SellType { get; set; }
        double Square { get; set; }
        Address _Address { get; set; }
    }
}
