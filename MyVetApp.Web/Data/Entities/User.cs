using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyVetApp.Web.Data.Entities
{
    public class User : IdentityUser
    {
        [Display(Name = "Document")]
        [Required(ErrorMessage = "The Field {0} is mandatory")]
        [MaxLength(20, ErrorMessage = "The {0} Field can not have more than {1} characters.")]
        public string Document { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "The Field {0} is mandatory")]
        [MaxLength(50, ErrorMessage = "The {0} Field can not have more than {1} characters.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "The Field {0} is mandatory")]
        [MaxLength(50, ErrorMessage = "The {0} Field can not have more than {1} characters.")]
        public string LastName { get; set; }

        [MaxLength(100, ErrorMessage = "The {0} Field can not have more than {1} characters.")]
        public string Address { get; set; }

        [Display(Name = "Full Name")]
        public string FullName => $"{FirstName} {FirstName}";

        [Display(Name = "Full Name")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

    }
}
