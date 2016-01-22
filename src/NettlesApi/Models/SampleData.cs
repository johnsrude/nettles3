using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Entity;

namespace NettlesApi.Models
{
    public static class SampleData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var db = serviceProvider.GetService(typeof(NettlesContext)) as NettlesContext;
            if (db == null) return;

            // For now, reset database for every new run. 
            // Code to reset database on changes is below.
            Clear(db);
            AddShows(db);
        }

        private static void AddShows(NettlesContext db)
        {
            var fulton = new Venue()
            {
                Name = "Fulton Community Center",
                StreetAddress = "68 SW Miles",
                City = "Portland",
                State = "OR",
                Phone = null,
                Url = null
            };
            db.Venues.Add(fulton);

            var milwaukie = new Venue()
                 {
                     Name = "Milwaukie Community Club",
                     StreetAddress = "10666 SE 42nd Ave",
                     City = "Milwaukie",
                     State = "OR",
                     Phone = null,
                     Url = null,
                 };
            db.Venues.Add(milwaukie);

            var shows = new List<Show>()
            {
                new Show()
                {
                    Time = new DateTime(2016, 1, 9, 20, 0, 0),
                    Title = "Portland Country Dance Community Contra Dance",
                    Note = "Beginner's lesson at 7:30 pm",
                    ShowUrl = "http://www.portlandcountrydance.org/Dances.htm",
                    Image = null,
                    Venue = fulton,
                    Callers = new List<Caller>()
                    {
                        new Caller()
                        {
                            FullName = "Amy Carroll",
                        },
                    }
                },
                new Show()
                {
                    Time = new DateTime(2016, 3, 13, 0, 0, 0),
                    Title = "Portland Roadhouse Contra Dance",
                    Note = null,
                    ShowUrl = "http://portlandroadhouse.org/",
                    Image = null,
                    Venue = milwaukie,
                    Callers = null,
                },
            };
            //if (db.Shows.Count() == shows.Count) return;
            db.Shows.AddRange(shows, GraphBehavior.IncludeDependents);
            db.SaveChanges();
        }

        private static void Clear(NettlesContext db)
        {
            db.Shows.RemoveRange(db.Shows);
            db.Callers.RemoveRange(db.Callers);
            db.Images.RemoveRange(db.Images);
            db.Venues.RemoveRange(db.Venues);
            db.SaveChanges();
        }

    }
}
