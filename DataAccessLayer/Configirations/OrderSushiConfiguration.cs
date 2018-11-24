using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configirations
{
    public class OrderSushiConfiguration : EntityTypeConfiguration<OrderSushi>
    {
        public OrderSushiConfiguration()
        {
            HasKey(o => new { o.OrderId, o.SushiId });
            Property(o => o.Amount).IsRequired();
        }
    }
}
