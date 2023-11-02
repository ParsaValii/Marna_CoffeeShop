using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain;
using Service.Interfaces;

namespace Service.Services
{
    public class CustomerOrderListService : ICustomerOrderListService
    {
        CoffeShopDbContext _context;

        public CustomerOrderListService(CoffeShopDbContext context)
        {
            _context = context;
        }
        public void AddToOrderList(AddToOrderListDto request)
        {
            if (_context.Items.Any(e => e.Name == request.name))
            {
                Item item1;
                item1.Price = _context.Items
                    .Where(e => e.Name == request.name)
                    .Select(e => e.Price)
            }
        }
    }
}