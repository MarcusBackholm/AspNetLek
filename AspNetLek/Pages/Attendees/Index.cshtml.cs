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
    public class IndexModel : PageModel
    {
        private readonly AspNetLek.Data.AspNetLekContext _context;

        public IndexModel(AspNetLek.Data.AspNetLekContext context)
        {
            _context = context;
        }

        public IList<Attendee> Attendee { get;set; }

        public async Task OnGetAsync()
        {
            Attendee = await _context.Attendee.ToListAsync();
        }
    }
}
