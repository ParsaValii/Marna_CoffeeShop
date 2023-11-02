using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Item
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required decimal Price { get; set; }
    }
}
