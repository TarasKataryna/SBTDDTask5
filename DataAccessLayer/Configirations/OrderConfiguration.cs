using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configirations
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            HasKey(o => o.Id);

            HasMany(o => o.OrderSushis).WithRequired(o => o.Order).HasForeignKey(o => o.OrderId).WillCascadeOnDelete(true);
        }
    }
}
