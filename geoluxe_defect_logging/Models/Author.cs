using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace geoluxe_defect_logging.Models
{
    public class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}