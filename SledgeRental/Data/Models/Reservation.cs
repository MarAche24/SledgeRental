using System.ComponentModel.DataAnnotations;

namespace SledgeRental.Data.Models
{
    public class Reservation
    {
        [Key]
        public int Id{ get; set; }

        [Required]
        public DateOnly Date { get; set; }

        [Required]
        public TimeOnly StartTime { get; set; }

        [Required]
        public TimeOnly EndTime { get; set; }

        [Required]
        public ApplicationUser Customer { get; set; } = null!;

        [Required]
        public string CustomerId { get; set; } = null!;

        [Required]
        public Sledge Sledge { get; set; } = null!;

        [Required]
        public int SledgeId { get; set; }
    }
}
