using BookStore.Entities;
using BookStore.WebSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace BookStore.WebSite.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection connection = new SqlConnection();

        //private readonly IConfiguration configuration;
        //public HomeController(IConfiguration _configuration)
        //{
        //    configuration = _configuration;
        //}

        public HomeController(IConfiguration configuration)
        {
            connection.ConnectionString = configuration.GetConnectionString("BookStoreContext");
        }

        public IActionResult Index()
        {
            ViewBag.Categories = GetCategories();

            HomePageViewModel model = new HomePageViewModel();
            model.SizinIcinSectiklerimiz = GetBooks(false);
            model.CokSatanlar = GetBooks(true);

            return View(model);
        }

        private List<Category> GetCategories()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Categories order by Name", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            List<Category> categories = new List<Category>();

            foreach (DataRow row in dt.Rows)
            {
                categories.Add(new Category
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString()
                });
            }

            return categories;
        }

        private List<Book> GetBooks(bool isBestSeller)
        {
            string sqlCommand = "select top 4 * from dbo.Books where IsSelected=1 order by Name";
            if (isBestSeller)
                sqlCommand = "select top 4 * from dbo.Books where IsBestSeller=1 order by Name";

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, connection);
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
                    WriterId = Convert.ToInt32(row["WriterId"]),
                    IsSelected = Convert.ToBoolean(row["IsSelected"]),
                    IsBestSeller = Convert.ToBoolean(row["IsBestSeller"])
                };

                books.Add(book);
            }

            return books;
        }
    }
}
