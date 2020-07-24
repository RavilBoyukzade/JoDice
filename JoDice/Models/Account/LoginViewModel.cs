using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace JoDice.Models.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="E-poçt vacibdir")]
        [MaxLength(50,ErrorMessage ="E-poçt maximum 50 simvoldan ibarət ola bilər")]
        [EmailAddress(ErrorMessage ="Düzgün e-poçt daxil edin")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage ="Şifrə vacibdir")]
        [MaxLength(50,ErrorMessage ="Şifrə maximum 50 simvoldan ibarət ola bilər")]
        [MinLength(8,ErrorMessage ="Şifrə minimum 8 simvoldan ibarət ola bilər")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
