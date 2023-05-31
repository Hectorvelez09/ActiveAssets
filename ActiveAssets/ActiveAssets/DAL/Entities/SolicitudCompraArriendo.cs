using System.ComponentModel.DataAnnotations;

namespace ActiveAssets.DAL.Entities
{
    public class SolicitudCompraArriendo : Entity
    {
        [Display(Name = "Fecha de la solicitud")]
        public DateTime? FechaSolicitud { get; set; }

        [Required]
        public Guid IdInmueble { get; set; }

        [Required]
        public Guid CedulaCliente { get; set; }
    }
}
