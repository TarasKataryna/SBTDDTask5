using DataAccessLayer.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contracts
{
    public interface IUnitOfWork:IDisposable
    {
        ISushiRepository Sushis { get;}
        IOrderRepository Orders { get;}
        ICustomerRepository Customers { get; }
        void Complete();
    }
}
