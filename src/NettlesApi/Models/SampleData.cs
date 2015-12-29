﻿using System;
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

            var shows = new List<Show>()
            {
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
                        },
                    }
                },
                               new Show()
                {
                    Time = new DateTime(2016, 3, 13, 0, 0, 0),
                    Title = "Portland Roadhouse Contra Dance",
                    Note = null,
                    Url = "http://portlandroadhouse.org/",
                    Image = null,
                    Venue = new Venue()
                    {
                        Name = "Milwaukie Community Club",
                        StreetAddress = "10666 SE 42nd Ave",
                        City = "Milwaukie",
                        State = "OR",
                        Phone = null,
                        Url = null
                    },
                    Callers = null,
                },
            };

            if (db.Shows.Count() == shows.Count) return;
            ClearDatabase(db);
            db.Shows.AddRange(shows);
            db.SaveChanges();
        }

        private static void ClearDatabase(DbContext db)
        {
            db.Database.ExecuteSqlCommand("delete from Venue");
            db.Database.ExecuteSqlCommand("delete from Caller");
            db.Database.ExecuteSqlCommand("delete from Image");
            db.Database.ExecuteSqlCommand("delete from Show");
        }
    }
}
