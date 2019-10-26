using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyVetApp.Web.Data.Entities
{
    public class History
    {
        public int Id { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "The Field {0} is mandatory")]
        [MaxLength(100, ErrorMessage = "The {0} Field can not have more than {1} characters.")]
        public string Description { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "The Field {0} is mandatory")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string Remarks { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime DateLocal => Date.ToLocalTime();

        public ServiceType ServiceType { get; set; }
        public Pet Pet { get; set; }


    }
}
