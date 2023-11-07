using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Menu
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IList<Item> Items { get; set; }
    }
}
