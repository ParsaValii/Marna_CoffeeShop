using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;
using Service.Interfaces;

namespace Service.Services
{
    public class DisplayMenuService : IDisplayMenuService
    {
        CoffeShopDbContext _context;
        public DisplayMenuService(CoffeShopDbContext context)
        {
            _context = context;
        }

        public Task Display()
        {
            throw new NotImplementedException();
        }
    }
}