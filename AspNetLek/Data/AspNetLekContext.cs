using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AspNetLek.Models;

namespace AspNetLek.Data
{
    public class AspNetLekContext : DbContext
    {
        public AspNetLekContext (DbContextOptions<AspNetLekContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetLek.Models.Attendee> Attendee { get; set; }
        public DbSet<AspNetLek.Models.AttendeeEvent> AttendeeEvent { get; set; }
        public DbSet<AspNetLek.Models.Event> Event { get; set; }
        public DbSet<AspNetLek.Models.Organizer> Organizer { get; set; }
    }
}
