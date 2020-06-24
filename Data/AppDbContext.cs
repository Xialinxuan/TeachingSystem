using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TeachingSystem.Data
{
    public class TSSDbContext : IdentityDbContext<User>
    {
        public static class MyGlobals {
            public static int Systemstate = 1; 
            public static int MaxConnection = 100; 
            public static int PresentConnection = 0; 

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassChoice> ClassChoices { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReply> PostReplies { get; set; }
        public DbSet<UserClasses> UserClasses { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestResult> TestResults { get; set; }
        public DbSet<SpecialityCourse> SpecialityCourse { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Apply> Applies { get; set; }
        public TSSDbContext(DbContextOptions<TSSDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "Teacher", NormalizedName = "TEACHER" },
                new IdentityRole { Name = "Student", NormalizedName = "STUDENT" },
                new IdentityRole { Name = "Manager", NormalizedName = "MANAGER" });

            builder.Entity<UserClasses>().Property(e => e.UserClassesId).ValueGeneratedOnAdd();
            builder.Entity<Apply>().Property(e =>e.ApplyId).ValueGeneratedOnAdd();
        }
    }
}