using BookStore.Entities;
using BookStore.Entities.Helpers;
using BookStore.Panel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.Arm;

namespace BookStore.Panel.Controllers
{
    public class BooksController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        SqlConnection connection = new SqlConnection();
        public BooksController(IConfiguration configuration, IWebHostEnvironment environment)
        {
            connection.ConnectionString = configuration.GetConnectionString("BookStoreContext");
            _environment = environment;
        }

        public IActionResult Index()
        {
            SqlDataAdapter da = new SqlDataAdapter("select b.*, c.Name as CategoryName, w.NameSurname as WriterName from dbo.Books as b inner join dbo.Categories as c on c.Id=b.CategoryId inner join dbo.Writers as w on w.Id=b.WriterId order by b.Name", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            List<BookViewModel> books = new List<BookViewModel>();

            foreach (DataRow row in dt.Rows)
            {
                BookViewModel book = new BookViewModel
                {
                    Id = Convert.ToInt32(row["Id"]),
                    CategoryId = Convert.ToInt32(row["CategoryId"]),
                    Description = Convert.ToString(row["Description"]),
                    ImageUrl = row["ImageUrl"].ToString(),
                    Name = row["Name"].ToString(),
                    PageCount = Convert.ToInt32(row["PageCount"]),
                    Price = Convert.ToDouble(row["Price"]),
                    PublishDate = Convert.ToDateTime(row["PublishDate"]),
                    WriterId = Convert.ToInt32(row["WriterId"]),
                    CategoryName = row["CategoryName"].ToString(),
                    WriterName = row["WriterName"].ToString()
                };

                books.Add(book);
            }


            return View(books);
        }

        public IActionResult Create()
        {
            //ViewBag.KategoriListesi = GetCategories();

            BookCreateModel createModel = new BookCreateModel
            {
                Book = new Book(),
                Categories = GetCategories(),
                Writers = GetWriters()
            };

            return View(createModel);
        }

        [HttpPost]
        public IActionResult Create(BookCreateModel model, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                //resim.png
                string wwwRootPath = _environment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                string extension = Path.GetExtension(file.FileName);
                string newFileName = fileName + "-" + DateTime.Now.ToString("yyyyMMddhhmmssfff") + extension;
                //resim-20240208211800123.png

                string path = Path.Combine(wwwRootPath + "/uploads/books/", newFileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }


                SqlCommand cmd = new SqlCommand("insert into dbo.Books values (@name, @categoryId, @writerId, @pageCount, @price, @publishDate, @description, @imageUrl, '', '')", connection);
                cmd.Parameters.AddWithValue("name", model.Book.Name);
                cmd.Parameters.AddWithValue("categoryId", model.Book.CategoryId);
                cmd.Parameters.AddWithValue("writerId", model.Book.WriterId);
                cmd.Parameters.AddWithValue("pageCount", model.Book.PageCount);
                cmd.Parameters.AddWithValue("price", model.Book.Price);
                cmd.Parameters.AddWithValue("publishDate", model.Book.PublishDate);
                cmd.Parameters.AddWithValue("description", model.Book.Description);
                cmd.Parameters.AddWithValue("imageUrl", newFileName);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                //ViewBag.KategoriListesi = GetCategories();
                BookCreateModel createModel = new BookCreateModel
                {
                    Book = model.Book,
                    Categories = GetCategories(),
                    Writers = GetWriters()
                };

                return View(createModel);
                //return View(model);
            }
        }


        public List<Category> GetCategories()
        {
            List<Category> list = new List<Category>();

            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Categories order by Name", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Category
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString()
                });
            }


            return list;
        }

        public List<Writer> GetWriters()
        {
            List<Writer> list = new List<Writer>();

            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Writers order by NameSurname", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Writer
                {
                    Id = Convert.ToInt32(row["Id"]),
                    NameSurname = row["NameSurname"].ToString()
                });
            }


            return list;
        }

        public Book GetBook(int id)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Books where Id=@id", connection);
            da.SelectCommand.Parameters.AddWithValue("id", id);
            DataTable dt = new DataTable();
            da.Fill(dt);


            Book book = new Book
            {
                Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                CategoryId = Convert.ToInt32(dt.Rows[0]["CategoryId"]),
                Description = Convert.ToString(dt.Rows[0]["Description"]),
                ImageUrl = dt.Rows[0]["ImageUrl"].ToString(),
                Name = dt.Rows[0]["Name"].ToString(),
                PageCount = Convert.ToInt32(dt.Rows[0]["PageCount"]),
                Price = Convert.ToDouble(dt.Rows[0]["Price"]),
                PublishDate = Convert.ToDateTime(dt.Rows[0]["PublishDate"]),
                WriterId = Convert.ToInt32(dt.Rows[0]["WriterId"])
            };

            return book;
        }

        public IActionResult Edit(int id)
        {
            ViewBag.KategoriListesi = GetCategories();
            ViewBag.YazarListesi = GetWriters();

            //Book book = GetBook(id);
            //return View(book);

            return View(GetBook(id));
        }

        [HttpPost]
        public IActionResult Edit(Book model, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                if (file == null)
                {
                    model.ImageUrl = GetBook(model.Id).ImageUrl;
                }
                else
                {
                    //resim.png
                    string wwwRootPath = _environment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(file.FileName);
                    string extension = Path.GetExtension(file.FileName);
                    string newFileName = fileName + "-" + DateTime.Now.ToString("yyyyMMddhhmmssfff") + extension;
                    //resim-20240208211800123.png
                    model.ImageUrl = newFileName;

                    string path = Path.Combine(wwwRootPath + "/uploads/books/", newFileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                }


                SqlCommand cmd = new SqlCommand("update dbo.Books set Name=@name, CategoryId=@categoryId, WriterId=@writerId, PageCount=@pageCount, Price=@price, Publishdate=@publishDate, Description=@description, ImageUrl=@imageUrl where Id=@id", connection);
                cmd.Parameters.AddWithValue("id", model.Id);
                cmd.Parameters.AddWithValue("name", model.Name);
                cmd.Parameters.AddWithValue("categoryId", model.CategoryId);
                cmd.Parameters.AddWithValue("writerId", model.WriterId);
                cmd.Parameters.AddWithValue("pageCount", model.PageCount);
                cmd.Parameters.AddWithValue("price", model.Price);
                cmd.Parameters.AddWithValue("publishDate", model.PublishDate);
                cmd.Parameters.AddWithValue("description", model.Description);
                cmd.Parameters.AddWithValue("imageUrl", model.ImageUrl);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.KategoriListesi = GetCategories();
                ViewBag.YazarListesi = GetWriters();

                return View(model);
            }
        }
    }
}
