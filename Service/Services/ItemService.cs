using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
using Service.Dtos;
using Service.Interfaces;

namespace Service.Services
{
    public class ItemService : IItemService
    {
        CoffeShopDbContext _context;

        public ItemService(CoffeShopDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> CreateNewItem(CreateNewItemRequestDto request)
        {
            var item = new Item
            {
                Name = request.Name,
                Price = request.Price,
                Menu = await _context.Menu.FindAsync(request.MenuId)
            };
            await _context.Items.AddAsync(item);
            await _context.SaveChangesAsync();
            return item.Id;
        }
        public async Task RemoveItem(Guid id)
        {
            var item = await _context.Items.FindAsync(id);
            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
        }
        public async Task EditItem(Guid id, EditItemRequestDto request)
        {
            var item = await _context.Items.FindAsync(id);
            item.Name = request.Name;
            item.Price = request.Price;
            item.Menu = await _context.Menu.FindAsync(request.MenuId);
            await _context.SaveChangesAsync();
        }


    }
}