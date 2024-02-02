using BookStore.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace BookStore.Panel.Controllers
{
    public class WritersController : Controller
    {
        SqlConnection connection = new SqlConnection();

        public WritersController(IConfiguration configuration)
        {
            connection.ConnectionString = configuration.GetConnectionString("BookStoreContext");
        }


        public IActionResult Index()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Writers order by NameSurname", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            List<Writer> writers = new List<Writer>();

            foreach (DataRow row in dt.Rows)
            {
                Writer writer = new Writer
                {
                    Id = Convert.ToInt32(row["Id"]),
                    NameSurname = row["NameSurname"].ToString()
                };

                writers.Add(writer);
            }


            return View(writers);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Writer model)
        {
            if (ModelState.IsValid)
            {
                SqlCommand cmd = new SqlCommand("insert into dbo.Writers values (@name)", connection);
                cmd.Parameters.AddWithValue("name", model.NameSurname);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                return RedirectToAction("Index");
            }
            else
                return View(model);
        }


        public IActionResult Edit(int id)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Writers where Id=@id", connection);
            da.SelectCommand.Parameters.AddWithValue("id", id);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
                return RedirectToAction(nameof(Index));
            else
            {
                Writer writer = new Writer
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                    NameSurname = dt.Rows[0]["NameSurname"].ToString()
                };

                return View(writer);
            }
        }


        [HttpPost]
        public IActionResult Edit(Writer model)
        {
            if (ModelState.IsValid)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Writers where Id=@id", connection);
                da.SelectCommand.Parameters.AddWithValue("id", model.Id);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    ModelState.AddModelError(string.Empty, model.Id + " numaralı kayıt bulunamadı.");
                    return View(model);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update dbo.Writers set NameSurname=@name where Id=@id", connection);
                    cmd.Parameters.AddWithValue("id", model.Id);
                    cmd.Parameters.AddWithValue("name", model.NameSurname);

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
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Writers where Id=@id", connection);
            da.SelectCommand.Parameters.AddWithValue("id", id);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
                return RedirectToAction(nameof(Index));
            else
            {
                Writer writer = new Writer
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                    NameSurname = dt.Rows[0]["NameSurname"].ToString()
                };

                return View(writer);
            }
        }

        [HttpPost]
        public IActionResult Delete(Writer model)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Writers where Id=@id", connection);
            da.SelectCommand.Parameters.AddWithValue("id", model.Id);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                ModelState.AddModelError(string.Empty, model.Id + " numaralı kayıt bulunamadı.");
                return View(model);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("delete from dbo.Writers where Id=@id", connection);
                cmd.Parameters.AddWithValue("id", model.Id);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                return RedirectToAction(nameof(Index));
            }

        }
    }
}
