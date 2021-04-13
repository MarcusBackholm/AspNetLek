using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetLek.Models
{
    public class Organizer
    {
        public int ID { get; set; }
        [Required]
        public string OrganizerName { get; set; }
        public string OrganizerMail { get; set; }
        public string OrganizerPhoneNumber { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
