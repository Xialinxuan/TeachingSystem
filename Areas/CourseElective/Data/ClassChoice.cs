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
    public class ClassChoice
    {
        [Required]
        public long ClassChoiceId { get; set; }

        // 对应的教学班
        public Class Class { get; set; }

        // 所属的学生
        public User Student { get; set; }

        // 我只写了可能跟其他子系统产生联系的部分，其他请自行添加

    }
}