using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Blog3.Models
{
    [Table("Tags")]
    public class Tag
    {
        public int Id { get; set; }
        [StringLength(300)]
        public string TagName { get; set; }
    }
}