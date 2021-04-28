using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PC2.Controllers
{
    public class PresentacionController : Controller
    {
        private readonly ILogger<PresentacionController> _logger;

        public PresentacionController(ILogger<PresentacionController> logger)
        {
            _logger = logger;
        }

        public IActionResult Contacto()
        {
            ViewData["Mensaje"] = "Mensaje enviado";
            return View();
        }

        public IActionResult QuienesSomos()
        {
            return View();
        }
        public IActionResult ServiciosProductos()
        {
            return View();
        }

    }
}
