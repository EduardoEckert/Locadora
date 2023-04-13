using Microsoft.AspNetCore.Mvc;

namespace Locadora.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
