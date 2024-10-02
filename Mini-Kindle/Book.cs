using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Kindle
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _pageCount;
        private List<string> _text;
        private List<int> _bookmarks;

        public Book(string title, string author, List<string> text)
        {
            _title = title;
            _author = author;
            _text = text;
            _pageCount = text.Count;
            _bookmarks = new List<int>();
        }

        public string GetPage(int page)
        {
            if (page < 0 || page >= _pageCount)
            {
                throw new ArgumentOutOfRangeException("Page number is out of range");
            }
            else
            {
                return _text[page];
            }
        }

        public void ToggleBookmark(int page)
        {
            if (page < 0 || page >= _pageCount)
            {
                throw new ArgumentOutOfRangeException("Page number is out of range");
            }
            else
            {
                if (_bookmarks.Contains(page))
                {
                    _bookmarks.Remove(page);
                }
                else
                {
                    _bookmarks.Add(page);
                }
            }
        }

        public int GetPageCount()
        {
            return _pageCount;
        }
    }
}
