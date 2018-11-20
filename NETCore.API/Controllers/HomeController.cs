using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NETCore.API.Entities;

namespace NETCore.API.Controllers
{
    [Route("shop")]
    public class HomeController : Controller
    {
        private CityInfoContext cityInfoContext;

        public HomeController(CityInfoContext context)
        {
            this.cityInfoContext = context; 
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}