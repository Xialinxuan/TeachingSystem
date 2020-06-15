using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeachingSystem.Data
{
    // 回复
    public class PostReply
    {
        [Required]
        public long PostReplyId { get; set; }

        // 对应的帖子
        public Post Post { get; set; }

        // 发出的用户
        public User User { get; set; }

        // 我只写了可能跟其他子系统产生联系的部分，其他请自行添加

    }
}