using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
/*            var courses = new Course[]
            {
                new Course{CourseId = "1",Name="t0",Department="cs",Credit=3,PracticeHours=3,TheoryHours=1},
                new Course{CourseId = "2",Name="t1",Department="cs",Credit=2,PracticeHours=5,TheoryHours=1},
                new Course{CourseId = "3",Name="t2",Department="cs",Credit=1,PracticeHours=1,TheoryHours=1},
                new Course{CourseId = "4",Name="t3",Department="cs",Credit=4,PracticeHours=2,TheoryHours=1},
            };
            context.Courses.AddRange(courses);
            context.SaveChanges();
            var SpecialityCourse = new SpecialityCourse[]
            {
                new SpecialityCourse{SpecialityCourseID = "5",CourseId="2",UserID="111",UserName="giao"},
                new SpecialityCourse{SpecialityCourseID = "6",CourseId="2",UserID="222",UserName="giao"},
                new SpecialityCourse{SpecialityCourseID = "7",CourseId="2",UserID="333",UserName="giao"},
                new SpecialityCourse{SpecialityCourseID = "8",CourseId="2",UserID="444",UserName="giao"},
            };
            context.SpecialityCourse.AddRange(SpecialityCourse);
            context.SaveChanges();*/
            // var newClass = new newClass[]
            // {
            //     new newClass{newClassId = "4",CourseId="1",TeacherID="5",TeacherName="giao5",StuIDList=new List<string>(){"7754b690-d20a-4a56-85a5-df7fb2880f68","2"}},
            //     new newClass{newClassId = "5",CourseId="2",TeacherID="6",TeacherName="giao6",StuIDList=new List<string>(){"1","2"}},
            //     new newClass{newClassId = "6",CourseId="3",TeacherID="7",TeacherName="giao7",StuIDList=new List<string>(){"7754b690-d20a-4a56-85a5-df7fb2880f68","4"}},
            //     new newClass{newClassId = "7",CourseId="3",TeacherID="7",TeacherName="giao7",StuIDList=new List<string>(){"1","2"}},
            // };
            // context.newClass.AddRange(newClass);
            // context.SaveChanges();
        }
    }
}