using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AspNetLek.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetLek.Pages.Events
{
    public class DetailsModel : PageModel
    {
        private readonly AspNetLek.Data.AspNetLekContext _context;

        public DetailsModel(AspNetLek.Data.AspNetLekContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.FirstOrDefaultAsync(m => m.ID == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            AttendeeEvent joinedEvent = new AttendeeEvent()
            {
                Attendee = await _context.Attendee.Where(a => a.ID == 1).FirstOrDefaultAsync(),
                Event = await _context.Event.Where(e => e.ID == id).FirstOrDefaultAsync()
            };

            _context.AttendeeEvent.Add(joinedEvent);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Events/Index");
        }
    }
}
