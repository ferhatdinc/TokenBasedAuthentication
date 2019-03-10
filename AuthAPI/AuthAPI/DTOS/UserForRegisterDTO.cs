using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.DTOS
{
    public class UserForRegisterDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserRoleID { get; set; }
    }
}
