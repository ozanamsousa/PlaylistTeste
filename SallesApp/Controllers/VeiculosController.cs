using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SallesApp.Controllers
{
    [Route("[controller]")]
    public class VeiculosController : Controller
    {
        private readonly ILogger<VeiculosController> _logger;

        public VeiculosController(ILogger<VeiculosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
          var pasta = @"C:\";
          if(!Directory.Exists(pasta)){
            Directory.CreateDirectory(pata);
          }
        }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}