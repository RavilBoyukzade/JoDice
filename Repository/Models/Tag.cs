using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Tag : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string TagName { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
