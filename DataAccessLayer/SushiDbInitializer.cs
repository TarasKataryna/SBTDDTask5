using DataAccessLayer.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class SushiDbInitializer : CreateDatabaseIfNotExists<SushiOrderingContext>
    {
        protected override void Seed(SushiOrderingContext context)
        {
            Sushi nigiri = new Sushi { Name = "Nigiri", Price = 200, Description = "A topping, usually fish, served on top of sushi rice" };
            Sushi maki = new Sushi { Name = "Maki", Price = 180, Description = "Rice and filling wrapped in seaweed" };
            Sushi cheaps = new Sushi { Name = "Cheaps", Price = 70, Description = "Taste rice cheapses" };
            Sushi rolls = new Sushi { Name = "Rolls", Price = 90, Description = "Rolls wrapped in steak" };
            Sushi sashimi = new Sushi { Name = "Sashimi", Price = 150, Description = "Fish or shellfish served alone (no rice)" };
            Sushi uramaki = new Sushi { Name = "Uramaki", Price = 220, Description = "Rice is on the outside and seaweed wraps around the filling" };

            context.Sushis.AddRange(new List<Sushi>
            {
                nigiri,
                maki,
                cheaps,
                rolls,
                sashimi,
                uramaki
            });
            context.SaveChanges();
        }
    }
}