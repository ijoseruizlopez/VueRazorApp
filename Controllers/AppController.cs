using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VueRazorApp.Models;

namespace VueRazorApp.Controllers
{
    public class AppController : Controller
    {
        private readonly ILogger<AppController> _logger;

        public AppController(ILogger<AppController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Users()
        {
            var users = new List<object>
            {
                new { id = 1, name = "José Ruiz", role = "Software Engineer", country = "Perú", image = "https://cdn-icons-png.flaticon.com/512/219/219970.png" },
                new { id = 2, name = "Maria Gonzales", role = "QA Engineer", country = "Brazil", image = "https://cdn-icons-png.flaticon.com/512/219/219969.png" }            };

            return Json(users); // Devuelve el resultado como JSON
        }

    }
}
