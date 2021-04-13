using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetLek.Data;
using AspNetLek.Models;

namespace AspNetLek.Pages.Attendees
{
    public class DetailsModel : PageModel
    {
        private readonly AspNetLek.Data.AspNetLekContext _context;

        public DetailsModel(AspNetLek.Data.AspNetLekContext context)
        {
            _context = context;
        }

        public Attendee Attendee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Attendee = await _context.Attendee.FirstOrDefaultAsync(m => m.ID == id);

            if (Attendee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
