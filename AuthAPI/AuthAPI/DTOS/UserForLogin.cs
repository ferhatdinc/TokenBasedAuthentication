using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.DTOS
{
    public class UserForLogin
    {
        public int UserName { get; set; }
        public int Password { get; set; }
    }
}
