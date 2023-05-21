using System.ComponentModel.DataAnnotations;

namespace ActiveAssets.DAL.Entities
{
    public class EntityPersona
    {
        [Key]
        public Guid Cedula { get; set; }
    }
}
