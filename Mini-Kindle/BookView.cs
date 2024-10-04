using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Kindle
{
	public partial class BookView : Form
	{
		private Book _book;

		public BookView(Book b)
		{
			InitializeComponent();

			_book = b;

			this.RefreshPage();
		}

		public void RefreshPage()
		{
			this.Text = _book.Title;
			this.PageTextLabel.Text = _book.Text[_book.CurrentPage];
			this.PageNumberNumericUpDown.Value = _book.CurrentPage;

			if (_book.Bookmarks.Contains(_book.CurrentPage))
				this.BookmarkLabel.Text = "Bookmarked";
			else
				this.BookmarkLabel.Text = "";
		}

		private void FlipBackwardsButton_Click(object sender, EventArgs e)
		{
			_book.CurrentPage--;
			RefreshPage();
		}

		private void FlipForwardButton_Click(object sender, EventArgs e)
		{
			_book.CurrentPage++;
			RefreshPage();
		}

		private void GoToPageButton_Click(object sender, EventArgs e)
		{
			_book.CurrentPage = (int)this.PageNumberNumericUpDown.Value;
			RefreshPage();
		}

		private void CloseBookButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BookmarkPageButton_Click(object sender, EventArgs e)
		{
			this._book.ToggleBookmark();
			RefreshPage();
		}
	}
}
