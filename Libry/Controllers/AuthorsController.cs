using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Libry.Models;
using Libry.ViewModels;

namespace Libry.Controllers
{
    public class AuthorsController : Controller
    {

        private ApplicationDbContext _context;

        public AuthorsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Authors
        public ActionResult Index()
        {

            var authors = _context.Authors.ToList();

            return View(authors);
        }

        // GET: Authors/details/1
        public ActionResult Details(int Id)
        {
            var author = _context.BookAuthors.Include(ba => ba.Author).Include(ba => ba.Book).Where(ba => ba.AuthorId == Id);

            if (author == null)
                return HttpNotFound();


            return View(author);
        }
    }
}