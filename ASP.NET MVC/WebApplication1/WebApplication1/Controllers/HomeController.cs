using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            string[] dizi = new string[] { "Mercedes", "Opel", "Wolswagen" };

            return View(dizi);
        }

        public IActionResult About()
        {
            DateTime dateTime = DateTime.Now;
            string adi = "Aykut";



            return View("AboutDeneme");
        }
    }
}
