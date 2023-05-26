using System.ComponentModel.DataAnnotations;

namespace Webshop.Models
{
    public class EventType
    {
        [Key]
        public int EventTypeId { get; set; }
        [Required]
        public string Event { get; set; }
    }
}
