using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectDentist.Models
{
    public class Registration
    {
        [Key]
        public int RegistrationId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50,ErrorMessage = "Please Provide Your First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "Please Provide Your Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Please Provide Your Area Name")]
        public string Area { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Please Provide Your Area Name",MinimumLength = 4)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} Must Be at least {2} Character Long", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int TempValue { get; set; }

    }
}