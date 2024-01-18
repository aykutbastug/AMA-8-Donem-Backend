using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        List<Employee> employees = new List<Employee>();
        public IActionResult Index()
        {
            for (int i = 1; i < 15; i++)
            {
                Employee employee = new Employee
                {
                    Id = i,
                    Name = "Personel Adı",
                    Surname = "Soyadı " + i,
                    Durumu = i % 2 == 0 ? false : true,
                    Gorev = i % 2 == 0 ? Gorevler.Developer : Gorevler.TeamLead
                };

                employees.Add(employee);
            }
            

            return View(employees);
        }

        public IActionResult Detail()
        {
            Employee employee = new Employee
            {
                Id = 1,
                Name = "Aykut",
                Surname = "Baştuğ",
                Durumu = true,
                Gorev = Gorevler.Developer
            };

            return View(employee);
        }
    }
}
