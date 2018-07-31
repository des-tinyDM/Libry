using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Libry.Models;
using System.Data.Entity.Validation;


namespace Libry.Controllers
{
    public class BooksController : Controller
    {
        private ApplicationDbContext _context;

        public BooksController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Books
        [HttpGet]
        public ActionResult Index()
        {
            var books = _context.Books.ToList();

            return View(books);
        }

        public ActionResult Details(int Id)
        {
            var book = _context.BookAuthors.Include(ba => ba.Book).Include(ba => ba.Author).SingleOrDefault(b => b.BookId == Id);

            return View(book);
        }
    }
}