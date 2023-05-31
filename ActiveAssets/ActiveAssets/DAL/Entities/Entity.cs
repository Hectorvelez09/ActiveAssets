using System.ComponentModel.DataAnnotations;

namespace ActiveAssets.DAL.Entities
{
    public class Entity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
