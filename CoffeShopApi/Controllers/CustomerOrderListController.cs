using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace CoffeShopApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerOrderListController : ControllerBase
    {
        ICustomerOrderListService _CustomerOrderListService;
        public CustomerOrderListController(ICustomerOrderListService CustomerOrderListService)
        {
            _CustomerOrderListService = CustomerOrderListService;
        }
        //[HttpPost]

    }
}