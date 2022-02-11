using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKUL_EF_CF.Models
{
    public abstract class Kullanici
    {
        public int ID { get; set; }
        [ MaxLength(50),Required]

        public string FullName { get; set; }
        [MaxLength(50), Required]
        public string Email { get; set; }
        [Required, MaxLength(8)]

        public string Password { get; set; }
        [NotMapped] // veritabanına işleme

        public string Password2 { get; set; }  //formdan gelen sorguyu tutsun
        public string Phone { get; set; }

    }
}
