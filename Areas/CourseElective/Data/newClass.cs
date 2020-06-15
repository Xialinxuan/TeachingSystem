using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeachingSystem.Data
{
    // 教学班
    public class newClass
    {
        [Required]
        public string newClassId { get; set; }
        public string CourseId { get; set; }
        public string TeacherID { get; set; }
        public string TeacherName { get; set; }
        public List<string> StuIDList { get; set; }

        public Course Course { get; set; }

    }
}