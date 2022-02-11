using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Blog3.Models
{
    [Table("Categories")]
    public class Category
    {
        public int Id { get; set; }
        [StringLength(300)]
        public string CategoryName { get; set; }

    }
}