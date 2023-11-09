using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Entities;
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
        public async Task<Menu> DisplayMenu(Guid MeniId)
        {
            var menu = await _context.Menu.FindAsync(MeniId);
            return menu;
        }
    }
}