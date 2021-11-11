using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalApp.Controllers
{
    public class MonitorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
