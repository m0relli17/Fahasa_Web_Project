using Microsoft.AspNetCore.Mvc;

namespace FASAHA_CLONE.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult History()
        {
            return View();
        }
    }
}
