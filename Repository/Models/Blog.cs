using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Blog : BaseEntity
    {
        [Required]
        public string Photo { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        [MaxLength(5000)]
        public string Text { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
