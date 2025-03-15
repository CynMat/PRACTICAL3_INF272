using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace S1L05_RWD.Models
{
    public class Consult
    {
        [Display (Name = "First Name")]
        public string FirstName { get; set; }
        [Display (Name = "Last Name")]
        public string LastName { get; set; }
        [Display (Name = "Email Address")]
        public string EmailAddress { get; set; }
    }
}