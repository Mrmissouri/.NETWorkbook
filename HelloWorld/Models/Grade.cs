using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class Grades
    {
        public int ID { get; set; }

        [Required]
        public int StudentID { get; set; }

        public string TeacherName { get; set; }

        public string Subject { get; set; }

        public Assignment AssignmentNumber { get; set; }

        [MaxLength(50, ErrorMessage = "Your response is too long. Please limit your response to 50 characters.")]
        public string Notes { get; set; }
    }

    public enum Assignment
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten
    }

}
