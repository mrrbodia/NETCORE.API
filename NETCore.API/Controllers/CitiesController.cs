using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCore.API.Controllers
{
    [Route("api/[controller]")]
    public class CitiesController : Controller
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(new List<object>() {
                new { id = 0, Name = "Zhytomyr" },
                new { id = 1, Name = "Kyiv" }
            });
        }
    }
}
