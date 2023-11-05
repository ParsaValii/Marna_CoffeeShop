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
        public async Task<ActionResult<Guid>> CreateNewItem(CreateNewItemRequestDto request)
        {
            var id =  await _itemService.CreateNewItem(request);
            return Ok(id);
        }
        [HttpDelete("{ItemId}")]
        public async Task<ActionResult> RemoveItem(Guid ItemId)
        {
            await _itemService.RemoveItem(ItemId);
            return NoContent();
        }
        [HttpPatch("{ItemId}")]
        public async Task<ActionResult> EditItem(Guid ItemId , EditItemRequestDto request)
        {
            await _itemService.EditItem(ItemId, request);
            return Ok();
        }
    }
}
