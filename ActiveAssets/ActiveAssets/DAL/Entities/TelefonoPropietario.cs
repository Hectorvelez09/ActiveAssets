using System.ComponentModel.DataAnnotations;

namespace ActiveAssets.DAL.Entities
{
    public class TelefonoPropietario
    {
        [Display(Name = "Nombre del cliente")]
        [Required]
        [Key]
        public Guid CedulaPropietario { get; set; }

        [Display(Name = "Telefono del cliente")]
        public int Telefono { get; set; }
    }
}
