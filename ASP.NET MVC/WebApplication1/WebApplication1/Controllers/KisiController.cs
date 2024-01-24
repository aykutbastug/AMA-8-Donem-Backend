using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class KisiController : Controller
    {
        private readonly IConfiguration _configuration;
        SqlConnection connection = new SqlConnection();

        public KisiController(IConfiguration configuration)
        {
            _configuration = configuration;
            connection.ConnectionString = _configuration.GetConnectionString("Rehber");
        }

        public IActionResult Index()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Kisiler", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            List<Kisi> Kisiler = new List<Kisi>();
            foreach (DataRow row in dt.Rows)
            {
                Kisiler.Add(new Kisi
                {
                    Id = Convert.ToInt32(row["Id"].ToString()),
                    ImageUrl = row["ImageUrl"].ToString(),
                    Name = row["Name"].ToString(),
                    Phone = row["Phone"].ToString(),
                    Surname = row["Surname"].ToString()
                });
            }


            return View(Kisiler);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Kisi model)
        {
            if (ModelState.IsValid)
            {
                SqlCommand cmd = new SqlCommand("insert into dbo.Kisiler values (@Name, @Surname, @Phone, @ImageUrl)", connection);
                cmd.Parameters.AddWithValue("Name", model.Name);
                cmd.Parameters.AddWithValue("Surname", model.Surname);
                cmd.Parameters.AddWithValue("Phone", model.Phone);
                cmd.Parameters.AddWithValue("ImageUrl", model.ImageUrl);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                return RedirectToAction(nameof(Index));
            }
            else
                return View(model);
        }
    }
}
