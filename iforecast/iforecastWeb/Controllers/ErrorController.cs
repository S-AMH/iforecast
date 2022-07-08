using Microsoft.AspNetCore.Mvc;

namespace iforecastWeb.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult UnderConstruction()
        {
            return View();
        }
    }
}
