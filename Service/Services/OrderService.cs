using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain;
using Service.Interfaces;
using Service.Dtos;

namespace Service.Services
{
    public class OrderService : IOrderService
    {
        CoffeShopDbContext _context;

        public OrderService(CoffeShopDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> CreateOrder(CreateOrderRequestDto request)
        {
            var order = new Order()
            {
                Customer = await _context.customer.FindAsync(request.CustomerId),
                Items = new List<OrderItem>()
            };
            await _context.Order.AddAsync(order);
            await _context.SaveChangesAsync();

            return order.Id;
        }
        public async Task RemoveOrder(Guid id)
        {
            var order = await _context.Order.FindAsync(id);
            _context.Order.Remove(order);
            await _context.SaveChangesAsync();
        }
    }
}



// IList<OrderItem> _orders ;
// public async Task AddToOrderList(AddOrRemoveFromOrderDto request)
// {
//     var orderItem = new OrderItem()
//     {
//         Item = await _context.Items.FindAsync(request.id),
//         Quantity = request.quantity
//     };
//     _orders.Add(orderItem);
//     var order = new Order()
//     {
//         Items = _orders
//     };
//     await _context.Order.AddAsync(order);
//     await _context.SaveChangesAsync();
// }