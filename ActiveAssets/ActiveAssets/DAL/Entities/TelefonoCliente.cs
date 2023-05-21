using System.ComponentModel.DataAnnotations;

namespace ActiveAssets.DAL.Entities
{
    public class TelefonoCliente
    {
        [Display(Name = "Nombre del cliente")]
        [Required]
        [Key]
        public Guid CedulaCliente { get; set; }

        [Display(Name = "Telefono del cliente")]
        public int Telefono { get; set; }
    }
}
