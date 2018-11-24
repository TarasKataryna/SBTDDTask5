using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contracts.Repositories
{
    public interface ISushiRepository:IRepository<Sushi>
    {
        Sushi GetSushiWithOrders(int id);
    }
}
