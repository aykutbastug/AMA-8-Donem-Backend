using BookStore.Entities;

namespace BookStore.Panel.Models
{
    public class BookCreateModel
    {
        public Book Book { get; set; }
        public List<Category>? Categories { get; set; }
        public List<Writer>? Writers  { get; set; }
    }
}
