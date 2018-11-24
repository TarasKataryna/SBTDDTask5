using DataAccessLayer.Configirations;
using DataAccessLayer.Models;
using System.Data.Entity;
using System.Configuration;

namespace DataAccessLayer
{
    public class SushiOrderingContext:DbContext
    {
        public SushiOrderingContext():base("Default")
        {

        }
        static SushiOrderingContext()
        {
            Database.SetInitializer(new SushiDbInitializer());
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sushi> Sushis { get; set; }
        public DbSet<Order> Orders { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Configurations.Add(new CustomerConfiguration());
            builder.Configurations.Add(new SushiConfiguration());
            builder.Configurations.Add(new OrderConfiguration());
            builder.Configurations.Add(new OrderSushiConfiguration());
        }
    }    
}
