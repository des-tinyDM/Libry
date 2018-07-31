using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Libry.Models;

namespace Libry.ViewModels
{
    public class AuthorWithBooks
    {
        public int AuthorId { get; set; }
        public Author Author { get; set; }


        public IEnumerable<BookAuthor> BookAuthorItems { get; set; }
        public int[] BookAuthorIds { get; set; }

        public IEnumerable<Book> Books { get; set; }
        public int[] BookIds { get; set; }
    }
}