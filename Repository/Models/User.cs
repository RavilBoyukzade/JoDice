using Repository.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class User : BaseEntity
    {
        public UserList UserList { get; set; }
       
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(100)]
        public string Password { get; set; }
        [Required]
        [MaxLength(100)]
        public string Token { get; set; }
    }
}
