using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieFu.Models
{
    public class Person
    {        
        [Key]
        public int Id { get; set; }

        [Display(Name="First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }    

        [Display(Name = "Email")]
        [RegularExpression(@"([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)")]
        public string EmailAddress { get; set; }

        [Display(Name = "Phone Numbers")]
        [RegularExpression(@"\([\d]{3}\)[\s][\d]{3}[-][\d]{4}", ErrorMessage="Please use the format (204) 555-1234")]
        public string PhoneNumber { get; set; }

    }
}