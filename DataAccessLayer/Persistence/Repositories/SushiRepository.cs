using DataAccessLayer.Contracts.Repositories;
using DataAccessLayer.Models;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer.Persistence.Repositories
{
    public class SushiRepository:Repository<Sushi>,ISushiRepository
    {
        public SushiRepository(DbContext context):base(context)
        {

        }

        public Sushi GetSushiWithOrders(int id)
        {
            return SushiOrderingContext.Sushis.Include(s => s.OrderSushis.Select(o => o.Order.Customer)).SingleOrDefault(s => s.Id == id);
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
