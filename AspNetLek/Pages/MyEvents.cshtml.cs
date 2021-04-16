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
    public class MyEventsModel : PageModel
    {
        private readonly AspNetLek.Data.AspNetLekContext _context;

        public MyEventsModel(AspNetLek.Data.AspNetLekContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; }

        public async Task OnGetAsync()
        {
            var userJoin = await _context.Attendee
              .Where(e => e.ID == 1)
              .Include(a => a.JoinedEvents)
              .FirstOrDefaultAsync();

            Event = userJoin.JoinedEvents;
        }


    }
}
