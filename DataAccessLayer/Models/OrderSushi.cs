using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [Table("OrderSushi")]
    public class OrderSushi
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int SushiId { get; set; }
        public Sushi Sushi { get; set; }
        public int Amount { get; set; }
    }
}
