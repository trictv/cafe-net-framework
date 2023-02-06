using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe.Controllers
{
    public class EstruturaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
