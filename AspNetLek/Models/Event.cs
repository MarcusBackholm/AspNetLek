using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetLek.Models
{
    public class Event
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public string Adress { get; set; }
        public DateTime Date { get; set; }
        public Organizer Organizer { get; set; }
        public IList<Attendee> Attendees { get; set; }
    }
}
