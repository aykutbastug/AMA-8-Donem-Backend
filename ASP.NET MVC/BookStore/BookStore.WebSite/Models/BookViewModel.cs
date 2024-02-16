using BookStore.Entities;

namespace BookStore.WebSite.Models
{
    public class BookViewModel
    {
        public Book Book { get; set; }
        public Category Category { get; set; }
        public Writer Writer { get; set; }
        public List<Book> Books { get; set; }
    }
}
