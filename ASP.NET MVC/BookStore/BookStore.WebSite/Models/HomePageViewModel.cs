using BookStore.Entities;

namespace BookStore.WebSite.Models
{
    public class HomePageViewModel
    {
        public List<Book> SizinIcinSectiklerimiz { get; set; } = new List<Book>();
        public List<Book> CokSatanlar { get; set; } = new List<Book>();
    }
}
