using System.ComponentModel.DataAnnotations;

namespace AspNetLek.Models
{
    public class AttendeeEvent
    {
        public int ID { get; set; }
        [Required]
        public Attendee Attendee { get; set; }
        public Event Event { get; set; }
    }
}
