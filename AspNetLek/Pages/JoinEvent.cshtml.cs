using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetLek.Data;
using AspNetLek.Models;

namespace AspNetLek.Pages
{
    public class JoinEventModel : PageModel
    {
        private readonly AspNetLek.Data.AspNetLekContext _context;

        public JoinEventModel(AspNetLek.Data.AspNetLekContext context)
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
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.FirstOrDefaultAsync(m => m.ID == id);

            if (Event == null)
            {
                return NotFound();
            }

            var userJoin = await _context.Attendee
                .Where(e => e.ID == 1)
                .Include(a => a.JoinedEvents)
                .FirstOrDefaultAsync();

            userJoin.JoinedEvents.Add(Event);
            await _context.SaveChangesAsync();

            return Page();
        }
    }
}
