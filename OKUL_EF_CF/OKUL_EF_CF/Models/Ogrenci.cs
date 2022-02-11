using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OKUL_EF_CF.Models
{
    [Table("Ogrenciler")]
    public class Ogrenci: Kullanici
    {
        [Required,MaxLength(10)]
        //Index
        public string OkulNumarasi { get; set; }
        public string Sınıf { get; set; }
        public int OgretmenID { get; set; }
        public Ogretmen Ogretmen { get; set; }
    }
}