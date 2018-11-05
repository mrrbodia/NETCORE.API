using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NETCore.API.Controllers
{
    [Route("shop")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}