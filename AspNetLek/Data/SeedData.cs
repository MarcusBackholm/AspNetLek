using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using AspNetLek.Data;
using AspNetLek.Models;

namespace AspNetLek.Data
{
    public class SeedData
    {
        public static void Seeding(AspNetLekContext context)
        {
            context.Attendee.RemoveRange(context.Attendee);
            context.Event.RemoveRange(context.Event);

            context.Attendee.Add(new Attendee
            {
                ID = 1324,
                UserName = "Bjorn",
                Email = "bjornstromberg@codic.se",
                PhoneNumber = "073-423 93 44"
            });

            context.Event.Add(new Event
            {
                Title = "Marcus",
                Description = "Bästa killen",
                Place = "Halmstad",
                Adress = "Gamletullsgatan 10",
                Date = DateTime.Parse("2021-04-13"),
            });
            context.Event.Add(new Event
            {
                Title = "Kaffe häng",
                Description = "Kaffe för den som gillar",
                Place = "Halmstad",
                Adress = "kaffegatan 3",
                Date = DateTime.Parse("2021-06-22"),
            });
            context.Event.Add(new Event
            {
                Title = "Lakrisfabriken",
                Description = "Lakris för den som gillar",
                Place = "Halmstad",
                Adress = "Lakrisgatan 33",
                Date = DateTime.Parse("2021-08-01"),
            });
            context.SaveChanges();
        }
    }
}
