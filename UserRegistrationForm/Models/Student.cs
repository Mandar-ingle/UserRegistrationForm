using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserRegistrationForm.Models
{
    public class Student
    {
        [MaxLength(20), MinLength(1)]
        [Required(ErrorMessage = "FirstName is Mandatory")]
        public string First_Name { get; set; }


        [DataType(DataType.Text)]
        [MaxLength(20), MinLength(1)]
        [Required(ErrorMessage = "LastName is Mandatory")]
        public string Last_Name { get; set; }


        [DataType(DataType.Text)]
        [MaxLength(20), MinLength(1)]
        [Required(ErrorMessage = "UserName is Mandatory")]
        public string UserName { get; set; }


        [DataType(DataType.Text)]
        [StringLength(30, ErrorMessage = "password in between 5 to 30 characters")]
        [Required(ErrorMessage = "Passowrd is required")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [StringLength(16, ErrorMessage = "Must be between 5 and 50 characters", MinimumLength = 5)]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Number Required")]
        [Range(0, 10)]
        public int Contact { get; set; }
    }
}
