using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DataValidationMVC.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "please enter proper Name ")]
       
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [Range(18,100)]
        public int Age { get; set; }
    }
}