using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tbasket.Models
{
    public class Equipo
    {
        [Key]

        public String EquipoID { get; set; }


        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar {0}")]
        [Index("Equipo_Name_Index", 1, IsUnique = true)]
        [Display(Name = "Equipo")]

        public int DivisionID { get; set; }


        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El Campo {0} debe tener una longitud maxima de 50 caracteres")]
        [Display(Name = "Nombre")]


        public String Name { get; set; }

        public virtual Division Division { get; set; }
    }
}