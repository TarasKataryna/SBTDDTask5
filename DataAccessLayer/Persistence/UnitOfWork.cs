using DataAccessLayer.Contracts;
using DataAccessLayer.Contracts.Repositories;
using DataAccessLayer.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private SushiOrderingContext SushiOrderingContext;
        public UnitOfWork(SushiOrderingContext sushiOrderingContext)
        {
            SushiOrderingContext = sushiOrderingContext;
        }
        public ISushiRepository Sushis {
            get
            {
                if(Sushis==null)
                {
                    Sushis =  new SushiRepository(SushiOrderingContext);
                }
                return Sushis;
            }
            private set { }
        }
        public IOrderRepository Orders { get {
                if(Orders==null)
                {
                    Orders = new OrderRepository(SushiOrderingContext);
                }
                return Orders;
            }
            private set { }
        }
        public ICustomerRepository Customers { get {
                if (Customers == null)
                    Customers = new CustomerRepository(SushiOrderingContext);
                return Customers;
            }private set { } }

        public void Complete()
        {
            SushiOrderingContext.SaveChanges();
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    SushiOrderingContext.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
