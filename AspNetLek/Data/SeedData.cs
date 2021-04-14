using System;
using AspNetLek.Models;
using System.Linq;

namespace AspNetLek.Data
{
    public class SeedData
    {
        public static void SeedingData(AspNetLekContext context)
        {
            context.AttendeeEvent.RemoveRange(context.AttendeeEvent);
            context.Event.RemoveRange(context.Event);
            context.Attendee.RemoveRange(context.Attendee);
            context.SaveChanges();

            // Look for any Attendee.
            if (context.Attendee.Any())
            {
                return; // DB has been seeded
            }

            context.Attendee.Add(new Attendee
            {
                ID = 1,
                UserName = "Bjorn",
                Email = "bjornstromberg@codic.se",
                PhoneNumber = "073-423 93 44"
            });

            context.Event.Add(new Event
            {
                Title = "Marcus",
                Description = "Häng med bästa Bästa killen",
                Place = "Halmstad",
                Adress = "Gamletullsgatan 10",
                Date = DateTime.Parse("2021-04-13"),
            });
            context.Event.Add(new Event
            {
                Title = "Kaffe häng",
                Description = "Kaffe för den som gillar",
                Place = "Brokvarn",
                Adress = "kaffegatan 3",
                Date = DateTime.Parse("2021-06-22"),
            });
            context.Event.Add(new Event
            {
                Title = "Lakrisfabriken",
                Description = "Lakris för den som gillar",
                Place = "Malmö",
                Adress = "Lakrisgatan 33",
                Date = DateTime.Parse("2021-08-01"),
            });
            context.Event.Add(new Event
            {
                Title = "Star Wars",
                Description = "Star Wars maraton",
                Place = "Göteborg",
                Adress = "Star Wars vägen 18",
                Date = DateTime.Parse("2021-11-14"),
            });
            context.Event.Add(new Event
            {
                Title = "Snushörnan",
                Description = "Kom och hämta gratis snus",
                Place = "Nykvarn",
                Adress = "Snusarevägen 493",
                Date = DateTime.Parse("2023-02-01"),
            });
            context.Event.Add(new Event
            {
                Title = "Musik fest",
                Description = "För dig som vill festa lite med musik",
                Place = "Älmhult",
                Adress = "Hultarevägen 20",
                Date = DateTime.Parse("2022-01-01"),
            });
            context.SaveChanges();
        }
    }
}
