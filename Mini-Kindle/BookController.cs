using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Kindle
{
    public class BookController
    {
        private Book? _book;
        private int _currentPage;

        // Don't want to set a book in the constructor because we don't know what book we want to open
        public BookController()
        {
        }

        public void OpenBook(Book book)
        {
            _book = book;

            BookView bookView = new BookView(_book);

            _currentPage = 0;

            bookView.Show();
        }
    }
}
