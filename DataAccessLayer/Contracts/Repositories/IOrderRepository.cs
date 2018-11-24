using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contracts.Repositories
{
    public interface IOrderRepository:IRepository<Order>
    {
        Order GetOrderWithCustomer(int id);
        Order GetOrderWithSushis(int id);
    }
}
