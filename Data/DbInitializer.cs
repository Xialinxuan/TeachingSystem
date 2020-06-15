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
        public static void Initialize(TSSDbContext context){
            var SpecialityCourse = new SpecialityCourse[]
            {
                new SpecialityCourse{SpecialityCourseID = "5",CourseId="2",UserID="111",UserName="giao"},
                new SpecialityCourse{SpecialityCourseID = "6",CourseId="2",UserID="222",UserName="giao"},
                new SpecialityCourse{SpecialityCourseID = "7",CourseId="2",UserID="333",UserName="giao"},
                new SpecialityCourse{SpecialityCourseID = "8",CourseId="2",UserID="444",UserName="giao"},
            };
            context.SpecialityCourse.AddRange(SpecialityCourse);
            context.SaveChanges();
        }
    }
}