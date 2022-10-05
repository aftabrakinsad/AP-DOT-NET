using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MT_ASSIGNMENT_1_Validation.Models
{
    public class Validation
    {
        [Required(ErrorMessage = "Don't Have any name?")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name should contain 3 to 50 characters")]
        
        public string fullname { get; set; }
        [Required(ErrorMessage = "No ID, No Entry!")]
        
        public string aiubid { get; set; }
        [Required(ErrorMessage = "He or She?")]
        
        public string gender { get; set; }
        [Required(ErrorMessage ="xx-xxxxx-x@student.aiub.edu mail is required.")]
        
        public string aiubmail { get; set; }
        [Required(ErrorMessage ="We can't let you in without password.")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = "Please maintain 1 uppercase, 1 lowercase, 1 special charater and 1 number with minimum 8 digits")]
        
        public string pass { get; set; }
        [Required(ErrorMessage = "Until the password matched.")]
        [Compare("pass")]
        
        public string cpass { get; set; }
        [Required(ErrorMessage = "18+?")]
        
        public string dob { get; set; }
    }
}