using BookStore.Entities;

namespace BookStore.WebSite.Models
{
    public class CategoryViewModel
    {
        public Category Category { get; set; }

        public List<Book> Books { get; set; }
    }
}
