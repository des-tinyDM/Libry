using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Libry.Models
{
    public class BookAuthor
    {
        public int BookAuthorId { get; set; }

        public Author Author { get; set; }
        public int AuthorId { get; set; }

        public Book Book { get; set; }
        public int BookId { get; set; }

    }
}