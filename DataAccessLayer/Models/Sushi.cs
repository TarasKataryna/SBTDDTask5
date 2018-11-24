using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [Table("Sushi")]
    public class Sushi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public ICollection<OrderSushi> OrderSushis { get; set; }
        public Sushi()
        {
            OrderSushis = new List<OrderSushi>();
        }
    }
}
