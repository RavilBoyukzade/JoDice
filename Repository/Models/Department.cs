using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Department : BaseEntity
    {
        [Required]
        public string IconImage { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public bool IsPopular { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
