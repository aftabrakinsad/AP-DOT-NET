using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormValidation.SupportiveAnnotations
{
    public class AgeValidation : ValidationAttribute
    {
        public override bool IsValid(object dob)
        {
            DateTime age = DateTime.Now;
            age.AddYears(-18);
            return age > Convert.ToDateTime(dob);
        }
    }
}