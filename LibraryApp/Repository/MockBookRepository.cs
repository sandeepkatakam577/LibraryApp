using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Repository
{
    public class MockBookRepository:IBookRepository
    {
        public void CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int Id)
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            var books = GetBooks();
            return books.FirstOrDefault(x => x.Id == id);
        }
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{Id=1,BookName="Wings of Fire",Author="APJ Kalam",ISBN="IS12344",PublishedDate=Convert.ToDateTime("02/02/1997")},
                new Book{Id=2,BookName="The Secret",Author="Rhonda Byrne",ISBN="IS78483",PublishedDate=Convert.ToDateTime("12/07/2011")},
                new Book{Id=3,BookName="2 STATES",Author="Chetan Bhagat",ISBN="IS12124",PublishedDate=Convert.ToDateTime("02/02/2001")},
            };
        }

        public void UpdateBook(int Id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
