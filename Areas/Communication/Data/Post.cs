using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeachingSystem.Data
{
    // 帖子
    public class Post
    {
        [Required]
        public long PostId { get; set; }

        // 对应的教学班
        public Class Class { get; set; }

        // 发出的用户
        public User User { get; set; }

        public List<PostReply> Replies { get; set; }

        // 我只写了可能跟其他子系统产生联系的部分，其他请自行添加

    }
}