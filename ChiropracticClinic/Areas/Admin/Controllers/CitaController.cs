using Microsoft.AspNetCore.Mvc;

namespace ChiropracticClinic.Areas.Admin.Controllers
{
    public class CitaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
