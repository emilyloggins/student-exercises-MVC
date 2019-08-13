using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Student
    {
        [Display(Name = "Student Id")]
        //int? means the default value will be null, thus it is not "required"
        public int? StudentId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Slack Handle")]

        public string SlackHandle { get; set; }

        [Required]
        [Display(Name = "Cohort Id")]
        public int CohortId { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
