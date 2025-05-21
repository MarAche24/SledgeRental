using System.ComponentModel.DataAnnotations;

namespace SledgeRental.Data.Models.Views
{
    public class ReservationInfo
    {
        [Key]
        public int ReservationId { get; set; }

        public DateOnly ReservationDate { get; set; }
        
        public TimeOnly StartTime { get; set; }
        
        public TimeOnly EndTime { get; set; }

        public string CustomerName { get; set; } = null!;

        public string SledgeNumber { get; set; } = null!;

        public string SledgeKind { get; set; } = null!;
    }
}
