using Microsoft.AspNetCore.Mvc;

namespace nfsesp.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Inicial()
        {
            ViewData["Title"] = "Inicial";

            return View();
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}
