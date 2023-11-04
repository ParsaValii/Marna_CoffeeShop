using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Domain;
using Service.Services;
using Service.Interfaces;
using Service.Dtos;

namespace CoffeShopApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateNewItem(CreateNewItemRequestDto request)
        {
            await _itemService.CreateNewItem(request);
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult> RemoveOrder(RemoveItemRequestDto request)
        {
            await _itemService.RemoveItem(request);
            return Ok();
        }
    }
}
