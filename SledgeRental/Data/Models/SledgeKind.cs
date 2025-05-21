using System.ComponentModel.DataAnnotations;

namespace SledgeRental.Data.Models
{
    public class SledgeKind
    {
        [Key]
        public int Id { get; set; }

        [StringLength(256)]
        [Required]
        public string Name { get; set; } = null!;
    }
}
