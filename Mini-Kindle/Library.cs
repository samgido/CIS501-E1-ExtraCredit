using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Kindle
{
    public class Library
    {
        private List<Book> _books;

        public Library()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            _books.Remove(book);
        }

        public List<Book> GetBooks()
        {
            return _books;
        }

        public void SyncLibrary()
        {
            // Sync library with cloud
            return;
        }
    }
}
