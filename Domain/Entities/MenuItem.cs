using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MenuItem
    {
        public Guid Id { get; set; }
        public required Item Item { get; set; }
    }
}
