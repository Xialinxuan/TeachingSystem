using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeachingSystem.Data
{
    // 选课志愿
    public class AddCourse
    {
        [Required]
        public string AddCourseId { get; set; }

        // 对应的教学班
        public Class Class { get; set; }

        //所属的课程名称
        // public String CourseName { get; set; }

        // 所属的学生
        public String Name { get; set; }
        // 所属的学生姓名
        // public String StudentName { get; set; }
    }
}