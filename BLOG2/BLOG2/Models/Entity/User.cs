using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BLOG2.Models.Entity
{
    [Table("User")]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity) ]
        public int ID { get; set; }
        [StringLength(20), Required]
        public string Name { get; set; }
        [StringLength(20), Required]
        public string Surname { get; set; }
        [Required]
        public int Age { get; set; }

    }
}