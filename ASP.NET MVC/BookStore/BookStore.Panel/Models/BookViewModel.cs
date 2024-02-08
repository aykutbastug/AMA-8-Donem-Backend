using BookStore.Entities;
using System.ComponentModel;

namespace BookStore.Panel.Models
{
    public class BookViewModel : Book
    {
        public string CategoryName { get; set; }
        public string WriterName { get; set; }
    }
}
