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
    public class CourseBy_Selection
    {
        [Required]
        public string CourseBy_SelectionId { get; set; }

        // 对应的教学班
        public string ClassId { get; set; }

        //所属的课程名称
        // public String CourseName { get; set; }

        // 所属的学生
        public string Name { get; set; }
        // 所属的学生姓名
        // public String StudentName { get; set; }
    }
}