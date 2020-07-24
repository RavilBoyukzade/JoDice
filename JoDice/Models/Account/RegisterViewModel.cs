using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace JoDice.Models.Account
{
    public class RegisterViewModel
    {   /*User registration Name*/
        [Required(ErrorMessage ="Ad vacibdir")]
        [MaxLength(50,ErrorMessage ="Ad maximum 50 xarakter ola bilər")]
        public string Name { get; set; }

        /*User registration Surname*/
        [Required(ErrorMessage = "Soyadı vacibdir")]
        [MaxLength(50, ErrorMessage = "Soyadı maximum 50 xarakter ola bilər")]
        public string Surname { get; set; }

        /*User registration Email*/
        [Required(ErrorMessage = "E-poçt vacibdir")]
        [MaxLength(50, ErrorMessage = "E-poçt maximum 50 xarakter ola bilər")]
        [EmailAddress(ErrorMessage ="Düzgün e-poçt daxil edin")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /*User registration Password*/
        [Required(ErrorMessage ="Şifrə yazmağınız vacibdir")]
        [MaxLength(50,ErrorMessage ="Şifrənin uzunluğu maximum 50 xarakter ola bilər")]
        [MinLength(8,ErrorMessage = "Şifrənin uzunluğu minimum 8 xarakter ola bilər")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /*User registration Password confirm*/
        [Required(ErrorMessage = "Şifrə yazmağınız vacibdir")]
        [MaxLength(50, ErrorMessage = "Şifrənin uzunluğu maximum 50 xarakter ola bilər")]
        [MinLength(8, ErrorMessage = "Şifrənin uzunluğu minimum 8 xarakter ola bilər")]
        [Compare("Password",ErrorMessage ="Şifrə və şifrə təstigi eyni olmalıdır")]
        public string PasswordConfirm { get; set; }
    }
}
