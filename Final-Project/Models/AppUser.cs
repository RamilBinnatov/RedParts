using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public bool isActive { get; set; } = false;
        public char FirstName { get; internal set; }
    }
}
