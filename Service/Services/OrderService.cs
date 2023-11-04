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

        public async Task CreateOrder(CreateOrderRequestDto request)
        {
            var _order = new Order()
            {
                //todo : Customer = await _context.Customer.FindAsync(_context.id),
                Items = new List<OrderItem>()
            };   
        }



        public Task RemoveOrder(RemoveOrderRequestDto request)
        {
            throw new NotImplementedException();
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