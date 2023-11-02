using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public string CustomeName { get; set; }
        List<Item> InList = new List<Item>();
        public int TotalPrice { get; set; }

        public void CreateOrder(string CustomeName, params Item[] items) 
        { 
            
        }
    }
}
