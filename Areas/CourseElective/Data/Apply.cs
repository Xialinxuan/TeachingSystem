using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeachingSystem.Data
{
    public class Apply
    {
        [Required]
        public long ApplyId { get; set; }

        [Required]
        [StringLength(100)]
        public string Reason { get; set; }
        public User ClassID { get; set; }
        public User Student { get; set; }

    }
}