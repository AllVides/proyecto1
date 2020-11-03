using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace proyecto1.Controllers
{
    public class TorneoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
