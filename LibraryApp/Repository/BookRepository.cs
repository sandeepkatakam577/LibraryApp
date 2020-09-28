using LibraryApp.Data;
using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Repository
{
    public class BookRepository:IBookRepository
    {
        private ApplicationDbContext _dbContext = null;

        public BookRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Book GetBookById(int id)
        {
            return _dbContext.Books.ToList().SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _dbContext.Books.ToList();
        }
       
        public void CreateBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        public void DeleteBook(int Id)
        {
           
            var book = _dbContext.Books.SingleOrDefault(m => m.Id == Id);
            
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }


        public void UpdateBook(int Id,Book book)
        {
           
            var bookInDb = _dbContext.Books.SingleOrDefault(m => m.Id == Id);
           
            bookInDb.BookName = book.BookName;
            bookInDb.Author = book.Author;
            bookInDb.ISBN = book.ISBN;
            bookInDb.PublishedDate = book.PublishedDate;
            bookInDb.Genre = book.Genre;
            _dbContext.SaveChanges();
        }
     
    }
}
