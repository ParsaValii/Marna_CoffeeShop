using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Dtos;
using Service.Interfaces;
using Service.Services;

namespace CoffeShopApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpPost]
        public async Task<ActionResult> CreateCustomer(CreateCustomerDto request)
        {
            await _customerService.CreateCustomer(request);
            return Ok();
        }
        [HttpDelete]
        public async Task<ActionResult> RemoveCustomer(RemoveCustomerDto request)
        {
            await _customerService.RemoveCustomer(request);
            return Ok();
        }
    }
}