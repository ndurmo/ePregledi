﻿using System.ComponentModel.DataAnnotations;

namespace ePregledi.Models.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Abbreviation { get; set; }
    }
}
