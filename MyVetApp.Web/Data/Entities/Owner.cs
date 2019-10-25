using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace MyVetApp.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Field {0} is mandatory")]
        [MaxLength(30, ErrorMessage = "The {0} Field can not have more than {1} characters.")]
        public string Document { get; set; }

        [Required(ErrorMessage = "The Field {0} is mandatory")]
        [MaxLength(50, ErrorMessage = "The {0} Field can not have more than {1} characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The Field {0} is mandatory")]
        [MaxLength(50, ErrorMessage = "The {0} Field can not have more than {1} characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(20, ErrorMessage = "The {0} Field can not have more than {1} characters.")]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [Required(ErrorMessage = "The Field {0} is mandatory")]
        [MaxLength(20, ErrorMessage = "The {0} Field can not have more than {1} characters.")]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        [MaxLength(100, ErrorMessage = "The {0} Field can not have more than {1} characters.")]
        public string Address { get; set; }

        //public string FullName { get { return $"{FirstName} {LastName}"; } }

        [Display(Name = "Owner")]
        public string FullName => $"{FirstName} {FirstName}";

        [Display(Name = "Owner")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
    }
}
