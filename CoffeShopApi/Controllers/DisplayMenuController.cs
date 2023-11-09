using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace CoffeShopApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DisplayMenuController : ControllerBase
    {
        IDisplayMenuService _displayMenuService;
        public DisplayMenuController(IDisplayMenuService displayMenuService)
        {
            _displayMenuService = displayMenuService;
        }
        [HttpGet("{MenuId}")]
        public async Task<ActionResult<Menu>> DisplayMenu(Guid MenuId)
        {
            var menu = await _displayMenuService.DisplayMenu(MenuId); //todo: fix needed
            return Ok(menu);
        }
    }
}