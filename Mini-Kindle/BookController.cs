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
        private ChangePage? _changePage;
        private OpenBook? _openBook;

        // Don't want to set a book in the constructor because we don't know what book we want to open
        public BookController()
        {
        }

        public void OpenBook(Book book)
        {
            _book = book;
            _currentPage = 0;
            _openBook!(_book);
        }

        public void UpdatePage(int page)
        {
            if (page == -2 && _currentPage > 0)
            {
                _currentPage = _currentPage - 1;
            }
            else if (page == -1 && _currentPage < _book.GetPageCount())
            {
                _currentPage = _currentPage + 1;
            }
            else
            {
                _currentPage = page;
            }
            _changePage(_currentPage);
        }

        public void ToggleBookmark()
        {
            _book.ToggleBookmark(_currentPage);
        }

        public void SetChangePage(ChangePage changePage)
        {
            _changePage = changePage;
        }

        public void SetOpenBook(OpenBook openBook)
        {
            _openBook = openBook;
        }
    }
}
