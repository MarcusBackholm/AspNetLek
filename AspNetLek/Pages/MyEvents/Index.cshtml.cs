using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetLek.Models;

namespace AspNetLek.Pages.MyEvents
{
    public class IndexModel : PageModel
    {
        private readonly AspNetLek.Data.AspNetLekContext _context;

        public IndexModel(AspNetLek.Data.AspNetLekContext context)
        {
            _context = context;
        }

        public IList<AttendeeEvent> AttendeeEvent { get; set; }

        public async Task OnGetAsync()
        {
            AttendeeEvent = await _context.AttendeeEvent.Include(e => e.Event).ThenInclude(o => o.Organizer).Where(ae => ae.Attendee.ID == 1).ToListAsync();
        }
    }
}
