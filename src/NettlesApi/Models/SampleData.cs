using System;
using System.Collections.Generic;
using System.Linq;

namespace NettlesApi.Models
{
    public static class SampleData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var db = serviceProvider.GetService(typeof(NettlesContext)) as NettlesContext;

            if (db == null || db.Shows.Any()) return;

            db.Shows.AddRange(
                new Show()
                {
                    Time = new DateTime(2016, 1, 9, 20, 0, 0),
                    Title = "Portland Country Dance Community Contra Dance",
                    Note = "Beginner's lesson at 7:30 pm",
                    Url = "http://www.portlandcountrydance.org/Dances.htm",
                    Image = null,
                    Venue = new Venue()
                    {
                        Name = "Fulton Community Center",
                        StreetAddress = "68 SW Miles",
                        City = "Portland",
                        State = "OR",
                        Phone = null,
                        Url = null
                    },
                    Callers = new List<Caller>()
                    {
                        new Caller()
                        {
                            FullName = "Amy Carroll",
                        }

                    }
                }
                );
            db.SaveChanges();
        }
    }
}
