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
    public class CustomerRepository:Repository<Customer>,ICustomerRepository
    {
        public CustomerRepository(DbContext context):base(context)
        {

        }

        public Customer GetCustomerWithSushis(int id)
        {
            return SushiOrderingContext.Customers.Include(c => c.Orders.Select(o => o.OrderSushis.Select(s=>s.Sushi))).SingleOrDefault(s => s.Id == id);
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
