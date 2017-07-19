using Microsoft.AspNetCore.Mvc;

namespace MyAppAngular.Controllers
{
    public class HomeController: Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
