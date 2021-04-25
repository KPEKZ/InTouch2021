﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InTouch2021.Models
{
    public class FeedBackModel
    {
        [Key]

        public int Id { get; set; }

        [Required]
        public string name { get; set; }
        [Required]
        public string phoneNumber { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string studNumber { get; set; }

        [Required]
        public string message { get; set; }

        [Required]
        public string Value { get; set; }
    }
}
