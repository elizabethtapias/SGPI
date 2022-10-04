using Microsoft.AspNetCore.Mvc;

namespace SGPI.Controllers
{
    public class CoordinadorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BuscarCoordinador()
        {
            return View();
        }
        public IActionResult Entrevistas()
        {
            return View();
        }

        public IActionResult Homologacion()
        {
            return View();
        }

        public IActionResult ProgramarAsignatura()
        {
            return View();
        }

        public IActionResult ReportesC()
        {
            return View();
        }
    }
}
