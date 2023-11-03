using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain;
using Service.Interfaces;

namespace Service.Services
{
    public class OrderService : IOrderService
    {
        CoffeShopDbContext _context;

        public OrderService(CoffeShopDbContext context)
        {
            _context = context;
        }

        public void AddToOrderList()
        {
            
        }
        public void RemoveFromOrderList()
        {
            
        }
    }
}