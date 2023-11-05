using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service.Dtos;

namespace Service.Interfaces
{
    public interface IOrderService
    {
        // public Task AddToOrderList(AddOrRemoveFromOrderDto request);
        public Task<Guid> CreateOrder(CreateOrderRequestDto request);
        public Task RemoveOrder(Guid id);
    }
}