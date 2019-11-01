using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tbasket.Models
{
    public class Division
    {
        [Key]

        public int DivisionID { get; set; }

        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El Campo {0} debe tener una longitud maxima de 50 caracteres")]
        [Display(Name = "Division")]


        public String Name { get; set; }
    }
}