using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VueRazorApp.Models;

namespace VueRazorApp.Controllers
{
    public class MapController : Controller
    {
        private readonly ILogger<MapController> _logger;

        private readonly Dictionary<string, (double Latitude, double Longitude)> countryCoordinates = new Dictionary<string, (double Latitude, double Longitude)>
        {
            { "Perú", (-9.19, -75.0152) },
            { "USA", (37.0902, -95.7129) },
            { "Brazil", (-14.2350, -51.9253) },
            { "Canada", (56.1304, -106.3468) },
            { "Australia", (-25.2744, 133.7751) },
            { "Mexico", (23.6345, -102.5528) },
            { "Spain", (40.4637, -3.7492) }
        };
        public MapController(ILogger<MapController> logger)
        {
            _logger = logger;
        }

        public IActionResult Countries()
        {

            var countries = new List<object>
            {
            new { code = "us", name = "United States" },
            new { code = "uk", name = "United Kingdom" },
            new { code = "ca", name = "Canada" },
            new { code = "au", name = "Australia" }
            };

            return Json(countries); // Devuelve los países como JSON
        }

        public async Task<IActionResult> Coordinates(string country)
        {
            await Task.Delay(3000);
            if (countryCoordinates.TryGetValue(country, out var coordinates))
            {
                // Si el país existe en el diccionario, devuelve las coordenadas
                return Json(new { Latitude = coordinates.Latitude, Longitude = coordinates.Longitude });
            }

            // Si el país no está en el diccionario, retorna un error
            return Json(new { error = "Country not found" });
        }
    }
}
