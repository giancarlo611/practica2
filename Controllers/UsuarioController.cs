using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PC2.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }

        public IActionResult ActualizarPerfil()
        {
            return View();
        }

        public IActionResult InicioSesion()
        {
            return View();
        }
        public IActionResult Registro()
        {
            return View();
        }

    }
}