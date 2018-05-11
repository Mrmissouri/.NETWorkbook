using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Required]
        [Display(Name = "Name")]
        [MinLength(2)]
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int GradeLevel { get; set; }
        public Gender StudentGender { get; set; }
        public Enrolled StudentEnrolled { get; set; }
        [Display(Name = "Did student pass STAAR?")]
        public bool Pass { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum Enrolled
    {
        Yes,
        No
    }


}
