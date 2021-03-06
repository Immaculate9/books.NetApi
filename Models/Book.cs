﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bookcrud.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Your title cannot contain more than 20 characters")
 ]
        public string Title { get; set; }
        [Required]
        
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
    }
}
