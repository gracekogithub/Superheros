﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperheroProject.Models
{
    public class Superhero
    {
        [Key]
        public string Name { get; set; }
        public string Ego { get; set; }
        public string PrimaryAbility { get; set; }
        public string SecondaryAbility { get; set; }


    }
}
