﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantsApp.Models
{
    public class Seed
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
    }
}
