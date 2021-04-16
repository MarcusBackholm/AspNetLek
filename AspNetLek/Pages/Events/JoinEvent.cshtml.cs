using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetLek.Data;
using AspNetLek.Models;

namespace AspNetLek.Pages.Events
{
    public class JoinEventsModel : PageModel
    {
        private readonly AspNetLek.Data.AspNetLekContext _context;
        
        public JoinEventsModel(AspNetLek.Data.AspNetLekContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Event Event { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.FirstOrDefaultAsync(m => m.ID == id); // Här ifrån blir det fel.

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (id == null)
            {
                return NotFound();
            }

            AttendeeEvent joinedEvent = new AttendeeEvent()
            {
                Attendee = await _context.Attendee.Where(a => a.ID == 1)
                .Include(e => e.AttendeeEvents)
                .FirstOrDefaultAsync(),
                Event = await _context.Event.Where(e => e.ID == id).FirstOrDefaultAsync()
            };

            return Page();

           //_context.AttendeeEvent.Add(joinedEvent);
           //await _context.SaveChangesAsync();
           //return RedirectToPage("/Events/Index"); // Ändra
        }

    }
}
