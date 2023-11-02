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
    }
}