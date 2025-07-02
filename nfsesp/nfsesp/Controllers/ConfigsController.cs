using Microsoft.AspNetCore.Mvc;

namespace nfsesp.Controllers
{
    public class ConfigsController : Controller
    {
        public IActionResult Empresa()
        {
            ViewData["Title"] = "Empresa";

            return View();
        }
    }
}
