using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SallesApp.Views
{
    public class Veiculos : PageModel
    {
        private readonly ILogger<Veiculos> _logger;

        public Veiculos(ILogger<Veiculos> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}