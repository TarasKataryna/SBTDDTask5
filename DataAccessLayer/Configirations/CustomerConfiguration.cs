using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configirations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.FirstName).IsRequired().HasMaxLength(30);
            Property(c => c.LastName).IsRequired().HasMaxLength(30);

            Property(c => c.UserName).IsRequired().HasMaxLength(30);
            Property(c => c.Password).IsRequired().HasMaxLength(30);

            HasMany(c => c.Orders).WithRequired(o => o.Customer).HasForeignKey(o => o.CustomerId).WillCascadeOnDelete(true);
        }
    }
}
