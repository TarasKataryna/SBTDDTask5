using DataAccessLayer.Configirations;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SushiOrderingContext:DbContext
    {
        public SushiOrderingContext():base()
        {

        }
        static SushiOrderingContext()
        {
            Database.SetInitializer<SushiOrderingContext>(new SushiDbInitializer());
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
