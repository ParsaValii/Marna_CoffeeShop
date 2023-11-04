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
    public class OrderController : ControllerBase
    {
        IOrderService _orderService;
        public OrderController(IOrderService OrderService)
        {
            _orderService = OrderService;
        }
        // [HttpPost]
        // public async Task<ActionResult> AddToOrderList([FromBody]AddOrRemoveFromOrderDto request)
        // {
        //     await _OrderService.AddToOrderList(request);
        //     return Ok();
        // }

        [HttpPost]
        public async Task<ActionResult> CreateOrder([FromBody]CreateOrderRequestDto request)
        {
            _orderService.CreateOrder(request);
            return Ok();
        }
    }
}