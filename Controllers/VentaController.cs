using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PC2.Controllers
{
    public class VentaController : Controller
    {
        private readonly ILogger<VentaController> _logger;

        public VentaController(ILogger<VentaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Catalogo()
        {
            return View();
        }

        public IActionResult ProductosDestacados()
        {
            return View();
        }
        public IActionResult Servicios()
        {
            return View();
        }

    }
}