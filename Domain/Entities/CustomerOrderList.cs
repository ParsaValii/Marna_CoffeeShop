using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CustomerOrderList
    {
        public Guid Id { get; set; }
        public required Item ItemAdded { get; set; }
        public int CountOfEach{ get; set; }

    }
}