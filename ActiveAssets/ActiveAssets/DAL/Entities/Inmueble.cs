using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace ActiveAssets.DAL.Entities
{
    public class Inmueble : Entity
    {
        [Display(Name = "Precio del alquiler")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public double PrecioAlquiler { get; set; }

        [Display(Name = "Ubicacion")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Ubicacion { get; set; }

        [Display(Name = "Metros")]
        public string Metros { get; set; }

        [Display(Name = "Cantidad de habitaciones")]
        public int CantHabitaciones { get; set; }

        [Display(Name = "Cantidad de baños")]
        public int CantBathrooms { get; set; }

        [Display(Name = "Precio de venta")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public double PrecioVenta { get; set; }

        [Required]
        public Guid IdTipoInmueble { get; set; }

        [Required]
        public Guid CedulaPropietario { get; set; }
    }
}
