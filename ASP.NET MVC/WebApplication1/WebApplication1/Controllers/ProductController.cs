using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Urunler()
        {
            return View();
        }

        public IActionResult UrunDetay()
        {
            return View();
        }
    }
}
