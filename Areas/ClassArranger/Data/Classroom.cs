using System;
using System.ComponentModel.DataAnnotations;

namespace TeachingSystem.Data
{
    public class Classroom
    {
        [Required]
        public int ClassroomId { get; set; }

        // 校区
        public string Campus { get; set; }

        // 建筑
        public string Building { get; set; }

        // 房间号
        public int RoomNumber { get; set; }

        // 教师名
        public string ClassroomName { get; set; }

        // 教室容量
        [CustomValidation(typeof(Classroom), nameof(ValidateCapacity))]
        public int Capacity { get; set; }

        public static ValidationResult ValidateCapacity(int cap, ValidationContext vc)
        {
            return cap > 0 ? ValidationResult.Success : new ValidationResult("Incorrect Capacity", new[] { vc.MemberName });
        }

        public override string ToString()
        {
            return ClassroomName;
        }
    }
}