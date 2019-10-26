using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyVetApp.Web.Data.Entities
{
    public class PetType
    {
        public int Id { get; set; }

        [Display(Name = "Pet Type")]
        [Required(ErrorMessage = "The Field {0} is mandatory")]
        [MaxLength(50, ErrorMessage = "The {0} Field can not have more than {1} characters.")]
        public string Name { get; set; }

        public ICollection<Pet> Pets { get; set; }

    }
}
