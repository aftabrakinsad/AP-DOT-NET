using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MT_ASSIGNMENT_2.Models
{
    public class Validation
    {
        [Display(Name = "Bike Name")]
        [Required(ErrorMessage = "Don't Have any name?")]
        public string Name { get; set; }

        [Display(Name = "Bike Price")]
        [Required(ErrorMessage = "Is it free?")]
        public int Price { get; set; }

        [Display(Name = "Bike Quantity")]
        [Required(ErrorMessage = "Koyta kinben vhai?")]
        public int Qty { get; set; }
    }
}