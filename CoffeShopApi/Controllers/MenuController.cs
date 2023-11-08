using System.Net;
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
    public class MenuController : ControllerBase
    {
        IMenuService _menuService;
        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }
        [HttpPost]
        public async Task<ActionResult<Guid>> CreateMenu(CreateMenuDto request)
        {
            var id = await _menuService.CreateMenu(request);
            return Ok(id);
        }
        [HttpDelete("{MenuId}")]
        public async Task<ActionResult> RemooveMenu(Guid MenuId)
        {
            await _menuService.RemoveMenu(MenuId);
            return NoContent();
        }
        [HttpPatch("{MenuId}")]
        public async Task<ActionResult> EditMenu(Guid MenuId, EditMenuDto request)
        {
            await _menuService.EditMenu(MenuId, request);
            return NoContent();
        }
    }
}