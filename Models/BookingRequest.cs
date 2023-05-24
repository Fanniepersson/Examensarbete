using System.ComponentModel.DataAnnotations;

namespace Webshop.Models
{
    public class BookingRequest
    {
        [Key]
        public int BookingId { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime DateOfEvent { get; set; }
        [Required]
        public int NumberOfGuests { get; set; }
        public string Location { get; set; }
        public int Budget { get; set; }
        public string Description { get; set; }
        public EventType EventType { get; set; }
    }
}
