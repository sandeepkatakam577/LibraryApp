using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApp.Models;
using LibraryApp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibraryApp.Controllers
{
    public class BooksController : Controller
    {
        private IBookRepository _bookRepos = null;
        public BooksController(IBookRepository bookRepository)
        {
            _bookRepos = bookRepository;
        }
        public IActionResult Index()
        {
            var books = _bookRepos.GetBooks();
            return View(books);
        }
        public IActionResult Details(int id)
        {
            var book = _bookRepos.GetBookById(id);
            return View(book);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            _bookRepos.CreateBook(book);
            return RedirectToAction("Index", "Books");
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var book = _bookRepos.GetBookById(Id);

            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(int Id,Book book)
        {
            if(!ModelState.IsValid)
            {
                
                return View();
            }
            _bookRepos.UpdateBook(Id,book);
            return RedirectToAction("Index", "Books");
        }
       [HttpPost]
       public IActionResult Delete(int Id)
        {
            _bookRepos.DeleteBook(Id);
            return RedirectToAction("Index", "Books");
        }
      
    }
}
