using System.ComponentModel.DataAnnotations;

namespace Webshop.Models
{
    public class EventType
    {
        public int EventTypeId { get; set; }
        [Required]
        public string Event { get; set; }
    }
}
