using System.ComponentModel.DataAnnotations;

namespace Webshop.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string? StreetAdress { get; set; }
        public string? City { get; set; }
        public Booking Booking { get; set; }
    }
}
