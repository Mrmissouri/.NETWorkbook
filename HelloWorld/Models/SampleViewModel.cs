using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class SampleViewModel
    {
        [Required]
        [MinLength(10)]
        [MaxLength(100)]
        [Display(Name = "Please, in what year were you born?")]

        public string Question { get; set; }

        //See here for list of answers
        public string Answer { get; set; }
        public int Age { get; set; }

    }
}
