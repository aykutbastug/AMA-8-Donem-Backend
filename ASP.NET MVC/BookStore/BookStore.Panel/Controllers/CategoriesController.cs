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
                //gelen kategori adı veritabanında kayıtlı mı değil mi diye bakmamız gerekiyor.
                //kayıtlısı geriye hata dönmesi gerekiyor
                //kayıtlı değilse kayıt işlemini yapması gerekiyor

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

        [HttpPost]
        public IActionResult Edit(Category model)
        {
            if (ModelState.IsValid)
            {
                SqlDataAdapter da = new SqlDataAdapter("select count(*) from dbo.Categories where Id=@id", connection);
                da.SelectCommand.Parameters.AddWithValue("id", model.Id);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int kayitSayisi = Convert.ToInt32(dt.Rows[0][0]);
                if (kayitSayisi == 0)
                {
                    ModelState.AddModelError(string.Empty, model.Id + " numaralı kayıt bulunamadı.");
                    return View(model);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update dbo.Categories set Name=@name where Id=@id", connection);
                    cmd.Parameters.AddWithValue("id", model.Id);
                    cmd.Parameters.AddWithValue("name", model.Name);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    return RedirectToAction(nameof(Index));
                }
            }
            else
                return View(model);
        }



        public IActionResult Delete(int id)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Categories where Id=@id", connection);
            da.SelectCommand.Parameters.AddWithValue("id", id);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
                return RedirectToAction(nameof(Index));
            else
            {
                Category category = new Category();
                category.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                category.Name = dt.Rows[0]["Name"].ToString();

                return View(category);
            }
        }

        [HttpPost]
        public IActionResult Delete(Category model)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Categories where Id=@id", connection);
            da.SelectCommand.Parameters.AddWithValue("id", model.Id);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                ModelState.AddModelError(string.Empty, model.Id + " numaralı kategori bulunamadı.");
                return View(model);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("delete from dbo.Categories where Id=@id", connection);
                cmd.Parameters.AddWithValue("id", model.Id);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                return RedirectToAction(nameof(Index));
            }
        }
    }
}
