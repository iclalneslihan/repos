using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Blog3.Models
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }
        [StringLength(20), Required]
        public string Name { get; set; }
        [StringLength(20), Required]
        public string SurName { get; set; }
        [Required]
        public int Age { get; set; }

        public Tag Tag { get; set; }
    }
}