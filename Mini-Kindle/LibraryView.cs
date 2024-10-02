namespace Mini_Kindle
{
	public partial class LibraryView : Form
	{
		private Library _library;
		private GetBooks _updateLibrary;
		private OpenBook _openBook;

		private Book _selectedBook;

		public LibraryView()
		{
			InitializeComponent();
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (sender is ListView listView)
			{
				if (listView.SelectedItems.Count > 0)
				{
					_selectedBook = _library.GetBooks().Find(b => b.Title == listView.SelectedItems[0].Text);
				}
			}
		}

		public void RefreshBooks()
		{
			foreach (Book b in _library.GetBooks())
			{
				listView1.Items.Add(b.Title);
			}
		}

		public void SetLibrary(Library library) => _library = library;
		public void SetGetBooksDelegate(GetBooks getBooks) => _updateLibrary = getBooks;
		public void SetOpenBookDelegate(OpenBook openBook) => _openBook = openBook;

		private void OpenBookClick(object sender, EventArgs e)
		{
			if (this._selectedBook == null) return; 

			this._openBook(this._selectedBook);
		}

		private void SyncButtonClick(object sender, EventArgs e)
		{
			this._updateLibrary();
		}
	}
}
