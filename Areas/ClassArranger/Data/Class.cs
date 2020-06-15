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

        // 我只写了可能跟其他子系统产生联系的部分，其他请自行添加

    }
}