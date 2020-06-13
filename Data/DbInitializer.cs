using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace TeachingSystem.Data
{
    public static class ApplicationDbInitializer
    {
        public static void SeedUsers(UserManager<User> userManager)
        {
            if (userManager.FindByNameAsync("admin").Result == null)
            {
                User user = new User
                {
                    UserName = "admin",
                    Email = "abc@xyz.com"
                };
                
                IdentityResult result = userManager.CreateAsync(user, "admin").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
            if (userManager.FindByNameAsync("xlx").Result == null)
            {
                User user = new User
                {
                    UserName = "xlx",
                    Email = "abc@xyz.com"
                };
                
                IdentityResult result = userManager.CreateAsync(user, "xlx").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Student").Wait();
                }
            }
            if (userManager.FindByNameAsync("manage").Result == null)
            {
                User user = new User
                {
                    UserName = "manage",
                    Email = "abc@xyz.com"
                };
                
                IdentityResult result = userManager.CreateAsync(user, "manage").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Manager").Wait();
                }
            }
        }
    }
}