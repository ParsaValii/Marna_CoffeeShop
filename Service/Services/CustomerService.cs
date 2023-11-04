using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Service.Interfaces;

namespace Service.Services
{
    public class CustomerService : ICustomerService
    {
        CoffeShopDbContext _context;
        public CustomerService(CoffeShopDbContext context)
        {
            _context = context;
        }
        
    }
}