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
    public class Classroom
    {
        [Required]
        public int ClassroomId { get; set; }

        public string Campus { get; set; }

        public string Building { get; set; }

        public int RoomNumber { get; set; }

        public string ClassroomName { get; set; }
        

    }
}