using System.ComponentModel.DataAnnotations;

namespace SledgeRental.Data.Models
{
    public class Sledge
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(512)]
        public string SledgeNumber { get; set; } = null!;

        [Required]
        public SledgeKind SledgeKind { get; set; } = null!;

        public int SledgeKindId { get; set; }

        [Required]
        public DateOnly RegistrationDate { get; set; }
    }
}
