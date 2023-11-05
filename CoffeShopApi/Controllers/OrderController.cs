using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Dtos;
using Service.Interfaces;

namespace CoffeShopApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        IOrderService _orderService;
        public OrdersController(IOrderService OrderService)
        {
            _orderService = OrderService;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateOrder(CreateOrderRequestDto request)
        {
            var id = await _orderService.CreateOrder(request);
            return Ok(id);
        }
        // api/orders/{orderId}
        [HttpDelete("{orderId}")]
        public async Task<ActionResult> RemoveOrder(Guid orderId)
        {
            await _orderService.RemoveOrder(orderId);
            return NoContent();
        }
    }
}