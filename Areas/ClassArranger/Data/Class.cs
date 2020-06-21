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
    public class Class
    {
        [Required]
        public string ClassId { get; set; }

        // 对应的课程
        public Course Course { get; set; }

        // 授课教师
        public User Teacher { get; set; }

        // 选上的学生
        public List<User> Students {get;set;}

        // 上课的教室
        public Classroom Classroom { get; set; }

        // 每周的上课时间
        // 七个二进制数表示该时间段是否上课
        public List<int> TeachTime { get; set; }

        // 考试时间
        public string TestTime {get; set;}
    }
}