using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Entities;
using Service.Dtos;
using Service.Interfaces;

namespace Service.Services
{
    public class MenuService : IMenuService
    {
        CoffeShopDbContext _Context;
        public MenuService(CoffeShopDbContext dbContext)
        {
            _Context = dbContext;
        }
        public async Task<Guid> CreateMenu(CreateMenuDto request)
        {
            var menu = new Menu()
            {
                Name = request.name
            };
            await _Context.Menu.AddAsync(menu);
            await _Context.SaveChangesAsync();
            return menu.Id;
            
        }

        
    }
}