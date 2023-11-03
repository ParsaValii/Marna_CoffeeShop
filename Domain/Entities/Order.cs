using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<OrederItem> Items { get; set; }
        [NotMapped]
        public decimal TotalPrice
            => Items.Sum(i => i.Quantity * i.Item.Price);
    }
}
