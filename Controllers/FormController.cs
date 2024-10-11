using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VueRazorApp.Models;

namespace VueRazorApp.Controllers
{
    public class FormController : Controller
    {
        private readonly ILogger<FormController> _logger;

        public FormController(ILogger<FormController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
