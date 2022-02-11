using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OKUL_EF_CF.Models
{
    [Table("Ogretmenler")]
    public class Ogretmen:Kullanici
    { 
        public int Maas { get; set; }
        [MaxLength(30)]

        public string Alan { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}