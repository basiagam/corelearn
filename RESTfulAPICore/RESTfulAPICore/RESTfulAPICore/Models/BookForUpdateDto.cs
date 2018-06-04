using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTfulAPICore.Models
{
    public class BookForUpdateDto : BookForManipulationDto
    {
        [Required(ErrorMessage = "Opis jest obowiązkowy.")]
        public override string Description { get => base.Description; set => base.Description = value; }
    }
}
