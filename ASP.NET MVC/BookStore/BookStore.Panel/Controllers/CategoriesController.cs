using BookStore.Entities;
using BookStore.Entities.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace BookStore.Panel.Controllers
{
    public class CategoriesController : Controller
    {
        SqlConnection connection = new SqlConnection();

        public CategoriesController(IConfiguration configuration)
        {
            connection.ConnectionString = configuration.GetConnectionString("BookStoreContext");
        }


        public IActionResult Index()
        {
            List<Category> list = new List<Category>();
            var rows = SqlHelper.GetRows("select * from dbo.Categories order by Name", connection, null);

            foreach (DataRow row in rows)
            {
                list.Add(new Category { 
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString()
                });
            }


            return View(list);
        }

        public IActionResult Create() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                SqlCommand cmd = new SqlCommand("insert into dbo.Categories values (@name)", connection);
                cmd.Parameters.AddWithValue("name", model.Name);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                return RedirectToAction(nameof(Index));
            }
            else
                return View(model);
        }


        public IActionResult Edit(int id)
        {
            List<CommandParameter> parameters = new List<CommandParameter>();
            parameters.Add(new CommandParameter { Name = "id", Value = id });

            var rows = SqlHelper.GetRows("select * from dbo.Categories where Id=@id", connection, parameters);

            if (rows != null && rows.Count > 0)
            {
                Category category = new Category();
                category.Id = Convert.ToInt32(rows[0]["Id"]);
                category.Name = rows[0]["Name"].ToString();

                return View(category);
            }
            else
                return RedirectToAction(nameof(Index));
        }
    }
}
