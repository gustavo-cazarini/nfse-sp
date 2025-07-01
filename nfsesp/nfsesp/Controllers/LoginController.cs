using Microsoft.AspNetCore.Mvc;
using nfsesp.ViewModels;

namespace nfsesp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Mensagem = "Verifique os dados preenchidos";
                return View(model);
            }

            var dadosTemp = new { email = "admin@admin.com", senha = "admin123" };

            if (model.Email != dadosTemp.email || model.Senha != dadosTemp.senha)
            {
                ViewBag.Mensagem = "Email ou Senha incorretos!";
                return View(model);
            }

            return RedirectToActionPermanent("Inicial", "Main");
        }
    }
}
