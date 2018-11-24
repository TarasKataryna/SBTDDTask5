using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configirations
{
    public class SushiConfiguration : EntityTypeConfiguration<Sushi>
    {
        public SushiConfiguration()
        {
            HasKey(s => s.Id);

            Property(s => s.Name).IsRequired();
            Property(s => s.Price).IsRequired();
            Property(s => s.Description).IsRequired();

            HasMany(s => s.OrderSushis).WithRequired(c => c.Sushi).HasForeignKey(c => c.SushiId);
        }
    }
}
