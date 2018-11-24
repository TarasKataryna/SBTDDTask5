using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contracts.Repositories
{
    public interface ICustomerRepository:IRepository<Customer>
    {
        Customer GetCustomerWithSushis(int id);
    }
}
