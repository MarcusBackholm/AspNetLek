using Microsoft.EntityFrameworkCore;

namespace AspNetLek.Data
{
    public class AspNetLekContext : DbContext
    {
        public AspNetLekContext (DbContextOptions<AspNetLekContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetLek.Models.Attendee> Attendee { get; set; }
        public DbSet<AspNetLek.Models.Event> Event { get; set; }
        public DbSet<AspNetLek.Models.Organizer> Organizer { get; set; }
    }
}
