﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.Models
{
    public class Role
    {
        [Key]
        public int UserRoleID { get; set; }
        public string UserRole { get; set; }
    }
}
