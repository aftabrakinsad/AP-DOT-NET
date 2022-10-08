using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MT_ASSIGNMENT_1_Validation.Models
{
    public class Validation
    {
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Don't Have any name?")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name should contain 3 to 50 characters")]
        [RegularExpression("^[a-zA-Z-_.\\s]+", ErrorMessage ="Valid name is required without special charecters!")]
        public string fullname { get; set; }

        [Display(Name = "AIUB ID")]
        [Required(ErrorMessage = "No ID, No Entry!")]
        [RegularExpression("^[1-9][0-9]-[0-9][0-9][0-9][0-9][0-9]-[1-3]+", ErrorMessage ="ki vhai? AIUB ID dao")]
        public string aiubid { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "He or She?")]
        public string gender { get; set; }

        [Display(Name = "AIUB Mail")]
        [Required(ErrorMessage ="xx-xxxxx-x@student.aiub.edu mail is required.")]
        [RegularExpression("^[1-9][0-9]-[0-9][0-9][0-9][0-9][0-9]-[1-3]@student.aiub.edu+", ErrorMessage ="Aiub er deya mail dao vaya")]
        public string aiubmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage ="We can't let you in without password.")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = "Please maintain 1 uppercase, 1 lowercase, 1 special charater and 1 number with minimum 8 digits")]
        public string pass { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Until the password matched.")]
        [Compare("pass", ErrorMessage ="Are you lost? Password didn't match.")]
        public string cpass { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "18+?")]
        public string dob { get; set; }
    }
}