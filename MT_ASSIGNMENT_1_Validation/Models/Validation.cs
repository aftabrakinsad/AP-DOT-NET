using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MT_ASSIGNMENT_1_Validation.Models
{
    public class Validation
    {
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name should contain 3 to 50 characters")]
        public string fullname { get; set; }
        [Required]
        public string aiubid { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string aiubmail { get; set; }
        [Required]
        public string pass { get; set; }
        [Required]
        [Compare("pass")]
        public string cpass { get; set; }
        [Required]
        public string dob { get; set; }
    }
}