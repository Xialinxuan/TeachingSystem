using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeachingSystem.Data
{
    // 课程，不同于“教学班”
    public class Course
    {
        [Required]
        public string CourseId { get; set; }
        public string Name { get; set; }
        [Required]

        public string Department { get; set; }
        public int Credit { get; set; }
        [Required]

        public int PracticeHours { get; set; }
        [Required]

        public int TheoryHours { get; set; }



    }
}