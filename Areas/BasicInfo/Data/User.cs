using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeachingSystem.Data
{
    // Add profile data for application users by adding properties to the User class
    public class User : IdentityUser
    {
        [NotMapped]
        public IEnumerable<string> Roles { get; set; }
        public string Name { get; set; }
        public string Belong { get; set; }
        public string Sex { get; set; }



    }
}