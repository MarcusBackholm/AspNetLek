using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
