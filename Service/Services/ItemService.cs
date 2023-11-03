using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
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

        public async Task CreateNewItem(CreateNewItemRequestDto request)
        {
            var item = new Item
            {
                Name = request.Name,
                Price = request.Price
            };

            await _context.Items.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        // public async Task<Item> GetItemAsync(Guid id)
        // {
        //     return await _context.Items.FindAsync(id);
        // }
    }
}