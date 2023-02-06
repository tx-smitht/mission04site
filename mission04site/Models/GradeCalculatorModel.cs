using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission04site.Models
{
    public class GradeCalculatorModel
    {
        // Assignments
        [Required]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public double Assignments { get; set; }

        // Group Projects
        [Required]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public double GroupProjects { get; set; }

        // Quizzes
        [Required]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public double Quizzes { get; set; }

        // Midterm
        [Required]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public double Midterm { get; set; }

        // Final
        [Required]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public double Final { get; set; }

        // INTEX
        [Required]
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public double INTEX { get; set; }
    }
}
