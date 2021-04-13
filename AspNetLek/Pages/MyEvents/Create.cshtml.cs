using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AspNetLek.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetLek.Pages.MyEvents
{
    public class CreateModel : PageModel
    {
        private readonly AspNetLek.Data.AspNetLekContext _context;

        public CreateModel(AspNetLek.Data.AspNetLekContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            AttendeeEvent joinedEvent = new AttendeeEvent()
            {
                Attendee = await _context.Attendee.Where(a => a.ID == 1).FirstOrDefaultAsync(),
                Event = await _context.Event.Where(e => e.ID == id).FirstOrDefaultAsync()
            };
            _context.AttendeeEvent.Add(joinedEvent);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Events/Details", new { id });
        }

        [BindProperty]
        public Event Event { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Event.Add(Event);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
