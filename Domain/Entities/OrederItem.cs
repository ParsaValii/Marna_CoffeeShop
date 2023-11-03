using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
    public class OrederItem
    {
        public Guid Id { get; set; }
        public Order Order { get; set; }
        public Item Item { get; set; }
        public Guid ItemId { get; set; }

        public int Quantity { get; set; }
    }
}