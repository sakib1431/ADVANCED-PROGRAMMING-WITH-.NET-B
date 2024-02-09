using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace FormApplication.Models
{
    public class form1
    {
        [Required(ErrorMessage ="Name can not be Empty")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage ="Name only contain Alphabets and Space")]
        public string Name { get; set; }

        /*---------------------------------*/
        [Required(ErrorMessage = "Username can not be Empty")]
        [StringLength(10, ErrorMessage = "Username must be at most 10 characters long")]
        [RegularExpression(@"^[a-zA-Z0-9!@#$%^&*()_+=\-]+$", ErrorMessage = "Username only contain alphanumeric characters and special characters")]
        public string Username { get; set; }

        /*---------------------------------*/
        [Required(ErrorMessage = "Student ID can not be Empty")]
        [RegularExpression(@"^\d{2}-\d{5}-[1-3]$", ErrorMessage = "ID format should be xx-xxxxx-x where x is a digit (0-9) and the last digit is between 1 and 3")]
        public string Id { get; set; }

        /*---------------------------------*/
        [Required(ErrorMessage = "Email can not be Empty")]
        [RegularExpression(@"^\d{2}-\d{5}-[1-3]@student.aiub.edu$", ErrorMessage = "Email format should be xx-xxxxx-x@student.aiub.edu where x is a digit (0-9) and the last digit is between 1 and 3")]
        public string Email { get; set; }
    }
}