using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Contexts
{
    public class CityInfoContext: DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointOfInterest { get; set; }

        public CityInfoContext(DbContextOptions<CityInfoContext> options): base(options)
        {
            // Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasData(
                new City()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "the one with the big park."
                },
                new City()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the Cathedral that was never really finished."
                },
                new City()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "the one with the big tower."
                });

            modelBuilder.Entity<PointOfInterest>()
                .HasData(
                new PointOfInterest()
                {
                    Id = 1,
                    CityId = 1,
                    Name = "Central Park",
                    Description = "The most visited urban park in the USA."
                },
                new PointOfInterest()
                {
                    Id = 2,
                    CityId = 1,
                    Name = "Empire State Building",
                    Description = "A 102-story skyscrapper located in Manhattan."
                },
                new PointOfInterest()
                {
                    Id = 3,
                    CityId = 2,
                    Name = "Cathedral",
                    Description = "A Gothic style cathedral, not finished yet."
                },
                 new PointOfInterest()
                 {
                     Id = 4,
                     CityId = 2,
                     Name = "Antwerp Central Station",
                     Description = "The finest example of railway architecture in Belgium."
                 },
                 new PointOfInterest()
                 {
                     Id = 5,
                     CityId = 3,
                     Name = "Eifel Tower",
                     Description = "An iron lattice tower on the Chanp de Mars."
                 },
                 new PointOfInterest()
                 {
                     Id = 6,
                     CityId = 3,
                     Name = "The Louvre",
                     Description = "The world's largest museum."
                 }
                );


            base.OnModelCreating(modelBuilder);

        }

    }
}
