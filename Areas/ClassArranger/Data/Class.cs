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
        public string Teacher { get; set; }

        // 选上的学生
        public List<string> Students {get;set;}

        public string Term { get; set; }

        public int ClassroomId { get; set; }

        public Classroom Classroom { get; set; }
        
        public int Contain { get; set; }
        
        public List<int> TeachTime { get; set; }

        public string TestTime { get; set; }
        // 我只写了可能跟其他子系统产生联系的部分，其他请自行添加

    }
}