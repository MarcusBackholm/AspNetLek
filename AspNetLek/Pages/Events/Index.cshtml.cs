using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetLek.Models;

namespace AspNetLek.Pages.Events
{
    public class IndexModel : PageModel
    {
        private readonly AspNetLek.Data.AspNetLekContext _context;

        public IndexModel(AspNetLek.Data.AspNetLekContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; }

        public async Task OnGetAsync()
        {
            Event = await _context.Event.Include(o => o.Organizer).ToListAsync();
        }
    }
}
