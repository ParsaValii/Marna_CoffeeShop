using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Interfaces;

namespace CoffeShopApi.Controllers
{
    [Route("[controller]")]
    public class TestController : Controller
    {
        ITestService _testService;

        public TestController(ITestService testService)
            => _testService = testService;

        [HttpGet]
        public ActionResult TestMethod()
        {       
            return Ok();
        }
    }
}