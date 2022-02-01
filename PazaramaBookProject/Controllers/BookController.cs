using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PazaramaBookProject.Data;
using PazaramaBookProject.Entity;
using PazaramaBookProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaramaBookProject.Controllers
{
    public class BookController : Controller
    {
        private readonly BookContext _context;
        public BookController(BookContext context)
        {
            _context = context;
        }
        // GET: BookController
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult List(int? id,string searchQuery)
        {
            var books = _context.Books.AsQueryable();
            if (id!=null)
            {
                books = books.Include(b => b.Genres).Where(b => b.Genres.Any(g => g.GenreId == id));
            }
            if (!string.IsNullOrEmpty(searchQuery))
            {
                books = books.Where(b => b.Title.ToLower().Contains(searchQuery.ToLower()) || b.Description.ToLower().Contains(searchQuery.ToLower()));
            }

            var model = new BooksViewModel()
            {
                Books = books.ToList()
            };
            ViewBag.GenreName = id != null ? _context.Genres.Find(id).GenreName : "Results for \"" + searchQuery+"\"";

            return View("Books", model);
        }
        // GET: BookController/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(_context.Books.Find(id));
        }

        // GET: BookController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookEntity book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            TempData["Message"] = book.Title + "Added";
            return RedirectToAction("List");
        }

        // GET: BookController/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(_context.Books.Find(id));
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ActionName("Edit")] //Aynı parametreye sahip iki Edit olamamasından dolayı ActionName'i dışarıdan verdim
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(BookEntity book)
        {
 
            _context.Books.Update(book);
            _context.SaveChanges();
            return RedirectToAction("List", "Book", new { @id = book.BookID });
        }


        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, string title)
        {
            var book = _context.Books.Find(id);
            _context.Books.Remove(book);
            _context.SaveChanges();
            TempData["Message"] = book.Title + "Deleted";
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult BookList(int id)
        {
            var books = _context.Books.AsQueryable();
            books = books.Include(b => b.Lists).Where(b => b.Lists.Any(g => g.ListID == id));

            var model = new BooksViewModel()
            {
                Books = books.ToList()
            };
            
            return View("Books", model);
        }
    }
}
