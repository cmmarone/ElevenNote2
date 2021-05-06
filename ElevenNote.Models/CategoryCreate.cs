﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryCreate
    {
        [Required]
        [MaxLength(40, ErrorMessage = "There are too many characters in this field.")]
        public string Name { get; set; }
    }
}
