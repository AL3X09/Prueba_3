using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba_3.Models
{
    public class PersonaClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } //Clave primaria

        [Required(ErrorMessage = "El Campo es obligatorio")]
        [Display(Name = "Número de Identificación")]
        public int Num_identificacion { get; set; }

        [Required(ErrorMessage = "El Campo es obligatorio")]
        [Display(Name = "Nombres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El Campo es obligatorio")]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Campo {0} es obligatorio")]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime Fecha_nacimiento { get; set; }

        [MaxLength(10, ErrorMessage = "El número de caracteres de {0} debe ser maximo de 10.")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Para {0} ingrese solo valores numéricos")]
        [Required(ErrorMessage = "El Campo es obligatorio")]
        [Display(Name = "Número de Telefono 1")]
        public int Telefono_1 { get; set; }

        [MaxLength(10, ErrorMessage = "El número de caracteres de {0} debe ser maximo de 10.")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Para {0} ingrese solo valores numéricos")]
        [Display(Name = "Número de Telefono 2")]
        public int? Telefono_2 { get; set; }

        [Required(ErrorMessage = "El Campo es obligatorio")]
        [Display(Name = "Correo electrónico")]
        public string Correo_electronico { get; set; }

        [Required(ErrorMessage = "El Campo es obligatorio")]
        [Display(Name = "Dirección de Residencia")]
        public string Direccion { get; set; }
    }
}
