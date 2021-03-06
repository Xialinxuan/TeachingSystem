using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeachingSystem.Data
{
    // 某个教学班的某次测试的结果
    public class TestResult
    {
        [Required]
        public long TestResultId { get; set; }

        // 对应的测试
        public Test Test { get; set; }
        // 所属的用户
        public User User { get; set; }

        // 我只写了可能跟其他子系统产生联系的部分，其他请自行添加

    }
}