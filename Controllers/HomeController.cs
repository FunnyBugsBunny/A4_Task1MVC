using A4_Task1MVC.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.SqlClient;
using System;
using System.Linq;

namespace A4_Task1MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (LibraryModelContext context = new LibraryModelContext())
            {
                List<Book> books = new List<Book>(context.SelOffCount(0, 12));
                return View(books);
            }
        }

        [HttpGet]
        public ActionResult EditBook(int bookId)
        {
            if (bookId == 0)
                return View(new Book());
            else
            {
                using (LibraryModelContext context = new LibraryModelContext())
                {
                    var book = context.Books.Where(e => e.id == bookId).First();
                    return View(book);
                }
            }
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult EditBook(Book book)
        {
            using (LibraryModelContext context = new LibraryModelContext())
            {
                if (book.id == 0)
                {
                    context.AddBook(book.title,
                                              book.author,
                                              book.year_published,
                                              book.number_pages,
                                              book.contents);
                }
                else
                {
                    context.UpdateBook(book.id,
                                              book.title,
                                              book.author,
                                              book.year_published,
                                              book.number_pages,
                                              book.contents);
                }
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public ActionResult DeleteBook(int bookId)
        {
            using (LibraryModelContext context = new LibraryModelContext())
            {
                context.DeleteBook((short)bookId);
                return RedirectToAction("Index");
            }
        }

    }
}