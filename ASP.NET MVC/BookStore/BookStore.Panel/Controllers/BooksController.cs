using Microsoft.AspNetCore.Mvc;

namespace BookStore.Panel.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
