using DataAccessLayer.Contracts.Repositories;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(DbContext context):base(context)
        {

        }
        public Order GetOrderWithCustomer(int id)
        {
            return SushiOrderingContext.Orders.Include(i => i.Customer).SingleOrDefault(i => i.Id == id);
        }

        public Order GetOrderWithSushis(int id)
        {
            return SushiOrderingContext.Orders.Include(o => o.OrderSushis.Select(i => i.Sushi)).SingleOrDefault(i => i.Id == id);
        }
        public SushiOrderingContext SushiOrderingContext
        {
            get
            {
                return Context as SushiOrderingContext;
            }
        }
    }
}
