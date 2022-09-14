using Microsoft.AspNetCore.Mvc;

namespace MyApplication.Controllers
{
    public class ScreenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
