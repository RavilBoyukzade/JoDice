using Repository.Enums;
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
        public JobType  JobType { get; set; }
        [Required]
        [MaxLength(100)]
        public string JobName { get; set; }
        [Required]
        public string Salary { get; set; }
        [Required]
        [MaxLength(500)]
        public string Adress { get; set; }
        [Required]
        [MaxLength(100)]
        public string JobTitle { get; set; }
        [Required]
        [MaxLength(1000)]
        public string JobAbout { get; set; }

        [Required]
        public bool IsFeatured { get; set; }
        public Category Category { get; set; }
        public ICollection<Country> Countries { get; set; }

    }
}
