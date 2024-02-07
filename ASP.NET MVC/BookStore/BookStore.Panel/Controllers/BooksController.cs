using BookStore.Entities;
using BookStore.Entities.Helpers;
using BookStore.Panel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace BookStore.Panel.Controllers
{
    public class BooksController : Controller
    {
        SqlConnection connection = new SqlConnection();
        public BooksController(IConfiguration configuration)
        {
            connection.ConnectionString = configuration.GetConnectionString("BookStoreContext");
        }

        public IActionResult Index()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Books order by Name", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            List<Book> books = new List<Book>();

            foreach (DataRow row in dt.Rows)
            {
                Book book = new Book
                {
                    Id = Convert.ToInt32(row["Id"]),
                    CategoryId = Convert.ToInt32(row["CategoryId"]),
                    Description = Convert.ToString(row["Description"]),
                    ImageUrl = row["ImageUrl"].ToString(),
                    Name = row["Name"].ToString(),
                    PageCount = Convert.ToInt32(row["PageCount"]),
                    Price = Convert.ToDouble(row["Price"]), 
                    PublishDate = Convert.ToDateTime(row["PublishDate"]),
                    WriterId = Convert.ToInt32(row["WriterId"])
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
        public IActionResult Create(BookCreateModel model)
        {            
            if (ModelState.IsValid)
            {
                //gelen kategori adı veritabanında kayıtlı mı değil mi diye bakmamız gerekiyor.
                //kayıtlısı geriye hata dönmesi gerekiyor
                //kayıtlı değilse kayıt işlemini yapması gerekiyor

                SqlCommand cmd = new SqlCommand("insert into dbo.Books values (@name, @categoryId, @writerId, @pageCount, @price, @publishDate, @description, @imageUrl, '', '')", connection);
                cmd.Parameters.AddWithValue("name", model.Book.Name);
                cmd.Parameters.AddWithValue("categoryId", model.Book.CategoryId);
                cmd.Parameters.AddWithValue("writerId", model.Book.WriterId);
                cmd.Parameters.AddWithValue("pageCount", model.Book.PageCount);
                cmd.Parameters.AddWithValue("price", model.Book.Price);
                cmd.Parameters.AddWithValue("publishDate", model.Book.PublishDate);
                cmd.Parameters.AddWithValue("description", model.Book.Description);
                cmd.Parameters.AddWithValue("imageUrl", model.Book.ImageUrl);

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
    }
}
