using RealEstate.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstate.Models
{
    public class Land : IRealEstate
    {
        public int RealEstateID { get; set; }
        public SellType _SellType { get; set; }
        public double Square { get; set; }
        public Address _Address { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
        public string Title { get; set; }
        public string Explaination { get; set; }
        public string LandPicUrl { get; set; }
        public User User { get; set; }
    
    }
}