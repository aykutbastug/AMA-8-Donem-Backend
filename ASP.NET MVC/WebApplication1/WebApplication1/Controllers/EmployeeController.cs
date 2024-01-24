using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication2.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employees = new List<Employee>();

        //GET : /Employee/Detail
        //[HttpGet]
        public IActionResult Index()
        {
            if (employees.Count == 0)
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
            }


            return View(employees);
        }


        //GET : /Employee/Detail/1
        public IActionResult Detail(int id)
        {
            //select top 1 e.* from dbo.Employees as e where e.EmployeeId=1
            Employee employee = employees.Where(x => x.Id == id).FirstOrDefault();
            ViewBag.kullaniciAdi = "aykut.bastug";
            ViewBag.personel = employee;
            ViewBag.sayi = 43;


            ViewData["kullaniciAdi"] = employee.Name + " " + employee.Surname;


            return View(employee);
        }


        //GET : /Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        //GET
        //POST => Kayıt ekleme işlemleri için data post etmeye yarar
        //PUT => Güncelleme işlemleri için data post etmeye yarar
        //DELETE => Silme işlemeleri için kullanılır
        //PATH => Post ve put un birleşimi
        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                if (employees.Count(x => x.Id == model.Id) == 0)
                {
                    employees.Add(model);
                    //return View("Index", employees);
                    //return RedirectToAction("Index");
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Girilen değer sistemde kayıtlı");
                    return View(model);
                }

            }
            else
            {
                return View(model);
            }
        }


        //GET : /Employee/Edit/1
        public IActionResult Edit(int id)
        {
            Employee employee = employees.Where(x => x.Id == id).FirstOrDefault();


            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee model)
        {
            if (ModelState.IsValid)
            {
                int index = employees.IndexOf(employees.Find(e => e.Id == model.Id));
                employees[index] = model;

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
           
        }


        //GET : /Employee/Delete/1
        public IActionResult Delete(int id)
        {
            Employee employee = employees.Where(x => x.Id == id).FirstOrDefault();


            return View(employee);
        }

        //POST : /Employee/Delete
        [HttpPost]
        public IActionResult Delete(int id, Employee model)
        {
            Employee employee = employees.Where(x => x.Id == id).FirstOrDefault();
            employees.Remove(employee);

            return RedirectToAction(nameof(Index));
        }

    }
}
