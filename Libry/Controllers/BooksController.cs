using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Libry.Models;
using System.Data.Entity.Validation;
using Libry.ViewModels;


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
        public ViewResult New()


        {
            var authors = _context.Authors.ToList();
            var viewModel = new BookFormViewModel
            {
                Authors = authors
            };

            return View("BookForm", viewModel);
        }
        public ActionResult Edit(int id)
        {
            var book = _context.Books.SingleOrDefault(b => b.BookId == id);
            var authors = _context.Authors.ToList();

            if (book == null)
                return HttpNotFound();

            var viewModel = new BookFormViewModel
            {
                Authors = authors
            };

            return View("BookForm", viewModel);
        }

        public ActionResult Save(Book book)
        {
            if (book.BookId == 0)
            {
                _context.Books.Add(book);
            }

            else
            {
                var bookInDb = _context.Books.Single(m => m.BookId == book.BookId);

                bookInDb.Title = book.Title;
                bookInDb.Genre = book.Genre;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Books");

        }
    }
}