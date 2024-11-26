using Microsoft.AspNetCore.Mvc;

namespace WebTimViecLam.tesst
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
