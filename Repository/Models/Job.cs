using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Job :BaseEntity
    {
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(100)]
        public string JobName { get; set; }
        [Required]
        public bool IsPpopular { get; set; }
        [Required]
        public bool IsFeatured { get; set; }
        public Category Category { get; set; }

    }
}
