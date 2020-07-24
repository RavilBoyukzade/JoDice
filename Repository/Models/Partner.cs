using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Partner : BaseEntity
    {
        [Required]
        public string Logo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
