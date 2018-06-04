using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTfulAPICore.Models
{
    public abstract class BookForManipulationDto
    {
        [Required(ErrorMessage = "Tytuł jest wymagany")]
        [MaxLength(100, ErrorMessage = "Dopuszczalna długość tytułu to max 100 znaków")]
        public string Title { get; set; }
        [MaxLength(500, ErrorMessage = "Dopuszczalna długość opisu to max 500 znaków")]
        public virtual string Description { get; set; }
    }
}
