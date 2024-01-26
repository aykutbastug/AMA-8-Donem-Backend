using ImageMagick;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class KisiController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _environment;
        SqlConnection connection = new SqlConnection();

        public KisiController(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _configuration = configuration;
            connection.ConnectionString = _configuration.GetConnectionString("Rehber");
            _environment = environment;
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
        public IActionResult Create(Kisi model, IFormFile file)
        {

            if (ModelState.IsValid)
            {
                model.ImageUrl = CopyFile(file);

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


        public IActionResult Details(int id)
        {
            Kisi kisi = GetKisi(id);

            return View(kisi);
        }

        private Kisi GetKisi(int id)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from dbo.Kisiler where Id=@KisiId", connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("KisiId", id);

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            Kisi kisi = new Kisi
            {
                Id = Convert.ToInt32(dataTable.Rows[0]["Id"].ToString()),
                ImageUrl = dataTable.Rows[0]["ImageUrl"].ToString(),
                Name = dataTable.Rows[0]["Name"].ToString(),
                Phone = dataTable.Rows[0]["Phone"].ToString(),
                Surname = dataTable.Rows[0]["Surname"].ToString()
            };
            return kisi;
        }

        public IActionResult Edit(int id)
        {
            return View(GetKisi(id));
        }

        [HttpPost]
        public IActionResult Edit(Kisi model, IFormFile? file)
        {

            if (ModelState.IsValid)
            {
                if (file == null)
                    model.ImageUrl = GetKisi(model.Id).ImageUrl;
                else
                    model.ImageUrl = CopyFile(file);

                SqlCommand cmd = new SqlCommand("update dbo.Kisiler set Name=@Name, Surname=@Surname, Phone=@Phone, ImageUrl=@ImageUrl where Id=@Id", connection);
                cmd.Parameters.AddWithValue("Id", model.Id);
                cmd.Parameters.AddWithValue("Name", model.Name);
                cmd.Parameters.AddWithValue("Surname", model.Surname);
                cmd.Parameters.AddWithValue("Phone", model.Phone);
                cmd.Parameters.AddWithValue("ImageUrl", model.ImageUrl);


                //if (file == null)
                //{
                //    SqlCommand cmd = new SqlCommand("update dbo.Kisiler set Name=@Name, Surname=@Surname, Phone=@Phone where Id=@Id", connection);
                //    cmd.Parameters.AddWithValue("Id", model.Id);
                //    cmd.Parameters.AddWithValue("Name", model.Name);
                //    cmd.Parameters.AddWithValue("Surname", model.Surname);
                //    cmd.Parameters.AddWithValue("Phone", model.Phone);
                //}
                //else
                //{
                //    model.ImageUrl = CopyFile(file);

                //    SqlCommand cmd = new SqlCommand("update dbo.Kisiler set Name=@Name, Surname=@Surname, Phone=@Phone, ImageUrl@ImageUrl where Id=@Id", connection);
                //    cmd.Parameters.AddWithValue("Id", model.Id);
                //    cmd.Parameters.AddWithValue("Name", model.Name);
                //    cmd.Parameters.AddWithValue("Surname", model.Surname);
                //    cmd.Parameters.AddWithValue("Phone", model.Phone);
                //    cmd.Parameters.AddWithValue("ImageUrl", model.ImageUrl);
                //}

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                return RedirectToAction(nameof(Index));
            }
            else
                return View(model);
        }

        private string CopyFile(IFormFile file)
        {
            string wwwRootPath = _environment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(file.FileName);
            string extension = Path.GetExtension(file.FileName);
            string newFileName = fileName + DateTime.Now.ToString("yyMMddmmssfff") + extension;

            string path = Path.Combine(wwwRootPath + "/uploads/", newFileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }


            MagickImage imageBig = new MagickImage(path);
            MagickGeometry sizeBig = new MagickGeometry(800, 400);
            //imageBig.Resize(800, 400);
            imageBig.Resize(sizeBig);
            imageBig.Quality = 40;

            string newFileNameBig = fileName + DateTime.Now.ToString("yyMMddmmssfff") + "_800_400" + extension;
            imageBig.Write(Path.Combine(wwwRootPath + "/uploads/", newFileNameBig));


            return newFileName;
        }


        public IActionResult Delete(int id)
        {
            return View(GetKisi(id));
        }

        [HttpPost]
        public IActionResult Delete(Kisi model)
        {
            string wwwRootPath = _environment.WebRootPath;
            string path = Path.Combine(wwwRootPath + "/uploads/", GetKisi(model.Id).ImageUrl);
            System.IO.File.Delete(path);


            SqlCommand cmd = new SqlCommand("delete from dbo.Kisiler where Id=@Id", connection);
            cmd.Parameters.AddWithValue("Id", model.Id);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();            

            return RedirectToAction(nameof(Index));
        }
    }
}
