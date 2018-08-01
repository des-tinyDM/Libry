using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Libry.Models;

namespace Libry.ViewModels
{
    public class BookFormViewModel
    {
       public IEnumerable<Author> Authors { get; set; }

        public int BookId { get; set; }

       public string Title { get; set; }
       public string Genre { get; set; }

       public string Display {
            get {
                return (BookId != 0) ? "Edit Book" : "New Book";
                }
       }

        public BookFormViewModel()
        {

        }

       public BookFormViewModel(Book book)
        {
            BookId = book.BookId;
            Title = book.Title;
            Genre = book.Genre;
        }

    }
}