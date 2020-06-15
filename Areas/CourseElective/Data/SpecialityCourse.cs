using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeachingSystem.Data
{
    public class SpecialityCourse
    {
        [Required]
        public string SpecialityCourseID { get; set; }

        //对应的课程号
        public string CourseId { get; set; }
        //用户ID 代替学生ID
        public string UserID { get; set; }
        //用户名
        public string UserName { get; set; }
        //导航属性 到Course
        public Course Course { get; set; }
    }
}