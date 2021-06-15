using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebLab4.Models
{
    public class SignUp
    {
        [Required(ErrorMessage = "Enter a FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter a LastName")]
        public string LastName { get; set; }

        [Required]
        public int BirthDay { get; set; }

        [Required]
        public string BirthMonth { get; set; }

        [Required]
        public int BirthYear { get; set; }

        [Required(ErrorMessage = "Check a Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress(ErrorMessage = "Incorrect email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter a Password")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Mismatch Password")]
        public string ComparePassword { get; set; }

        public bool Remember { get; set; }

        public string ResetCode { get; set; }


        public SignUp()
        {
            ResetCode = "2021";
        }


        public void generatenewCode()
        {
            Random rand = new Random();
            ResetCode = "";
            for (int i = 0; i < 4; i++)
                ResetCode += rand.Next(1, 9);
        }
    }
}
