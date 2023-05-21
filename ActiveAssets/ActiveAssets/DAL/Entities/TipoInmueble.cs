using System.ComponentModel.DataAnnotations;

namespace ActiveAssets.DAL.Entities
{
    public class TipoInmueble : Entity
    {
        [Display(Name = "Descripcion")]
        [MaxLength(250, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Descripcion { get; set; }
    }
}
