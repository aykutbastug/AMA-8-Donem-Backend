using Microsoft.AspNetCore.Mvc;

namespace BookStore.Panel.Controllers
{
    public class WritersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
