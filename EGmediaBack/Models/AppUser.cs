using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EGmediaBack.Models
{
    public class AppUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
