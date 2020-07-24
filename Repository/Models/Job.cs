using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Job :BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string JobName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Activity { get; set; }
        [Required]
        public bool IsPpopular { get; set; }
        [Required]
        public bool IsFeatured { get; set; }

    }
}
