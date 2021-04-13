using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetLek.Data;
using AspNetLek.Models;

namespace AspNetLek.Pages.Events
{
    public class MyEventModel : PageModel
    {
        private readonly AspNetLek.Data.AspNetLekContext _context;

        public MyEventModel(AspNetLek.Data.AspNetLekContext context)
        {
            _context = context;
        }

        public IList<AttendeeEvent> AttendeeEvent { get;set; }

        public async Task OnGetAsync()
        {
            AttendeeEvent = await _context.AttendeeEvent.Include(e=>e.Event).ThenInclude(o=>o.Organizer).Where(ae=>ae.Attendee.ID==1).
            ToListAsync();
        }
    }
}
