﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProductCreate
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
