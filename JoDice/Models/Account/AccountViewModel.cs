using Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoDice.Models.Account
{
    public class AccountViewModel
    {
        public UserList UserList { get; set; }
        public RegisterViewModel Register { get; set; }
        public LoginViewModel Login { get; set; }
    }
}
