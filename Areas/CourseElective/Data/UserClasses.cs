using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeachingSystem.Data
{
    // 与某个用户关联的所有教学班
    public class UserClasses
    {
        [Required]
        public long UserClassesId { get; set; }

        // 对应的教学班
        public List<string> ClassesId { get; set; }

        // 所属的用户
        public User User { get; set; }

        // 我只写了可能跟其他子系统产生联系的部分，其他请自行添加

    }
}