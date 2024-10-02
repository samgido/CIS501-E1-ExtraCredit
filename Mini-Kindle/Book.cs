using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Kindle
{
    public class Book
    {
        private string _author;
        private int _pageCount;
        private int _currentPage = 0;
        public string Title;
        public List<string> Text;
        public List<int> Bookmarks;

        public int CurrentPage
        {
            get => _currentPage;
            set
            {
                if (value >= 0 && value < _pageCount) _currentPage = value;
            }
        }

        public Book(string title, string author, List<string> text)
        {
            Title = title;
            _author = author;
            Text = text;
            _pageCount = text.Count;
            Bookmarks = new List<int>();
        }

        public string GetPage(int page)
        {
            if (page < 0 || page >= _pageCount)
            {
                throw new ArgumentOutOfRangeException("Page number is out of range");
            }
            else
            {
                return Text[page];
            }
        }

        public int GetPageCount()
        {
            return _pageCount;
        }
    }
}
