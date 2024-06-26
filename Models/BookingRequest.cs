﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Webshop.Models
{
    public class BookingRequest
    {
        [Key]
        public int BookingId { get; set; }
        [Required(ErrorMessage = "name is required.")]
        public string? Firstname { get; set; }
        [Required]
        public string? Lastname { get; set; }
        [Required(ErrorMessage = "email is required.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "phone is required.")]
        public string? PhoneNumber { get; set; }
        [Required(ErrorMessage = "when is the event happening? is required.")]
        [BindProperty, DataType(DataType.Date)]
        public DateTime? DateOfEvent { get; set; }
        [Required(ErrorMessage = "how many people? is required.")]
        public int? NumberOfGuests { get; set; }
        public string Location { get; set; }
        public int? Budget { get; set; }
        public string Description { get; set; }
        public int EventTypeId { get; set; }
        public EventType EventType { get; set; }
        public Customer Customer { get; set; }
        public DateTime RequestDate { get; set; }
        public Status Status { get; set; }
    }

    public enum Status
    {
        NotSet,
        Accepted,
        Dismissed
    }
}
