using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission3.Models
{
    public class GradeCalculatorModel
    {
        [Required]
        [Range (0, 1)]
        public decimal Assignments { get; set; }
        [Required]
        [Range(0, 1)]
        public decimal Projects { get; set; }
        [Required]
        [Range(0, 1)]
        public decimal Quizzes { get; set; }
        [Required]
        [Range(0, 1)]
        public decimal Exams { get; set; }
        [Required]
        [Range(0, 1)]
        public decimal Intex { get; set; }
    }
}
