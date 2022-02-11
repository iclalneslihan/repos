﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BLOG2.Models.Entity
{
    [Table("Address"]
    public class Address
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(300)]
        public string AddressText { get; set; }
        public string City { get; set; }
        public User user { get; set; }
    }
}