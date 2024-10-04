namespace Mini_Kindle
{
    public delegate void SyncLibrary();
    public delegate void GetBooks();
    public delegate void OpenBook(Book book);

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Book b1 = new Book("My First book", "Me", new List<string> { "Hello", "World" }); 
            Book b2 = new Book("My Second book", "Me", new List<string> { "New", "World", "Hello?", "Again" });
            Book b3 = new Book("My Third book", "Me", new List<string> { "Page 1", "Page 2", "Page 3", "Page 4", "Page 5", "Page 6" });
            Library l = new Library();
            l.AddBook(b1);
            l.AddBook(b2);
            l.AddBook(b3);
            LibraryController lc = new LibraryController(l);
            BookController bc = new BookController();

            LibraryView libraryView = new LibraryView();

            libraryView.SetLibrary(l);
            libraryView.SetOpenBookDelegate(bc.OpenBook);
            libraryView.SetGetBooksDelegate(lc.SyncLibrary);

            lc.SetSyncLibrary(libraryView.RefreshBooks);

            libraryView.RefreshBooks();

            Application.Run(libraryView);
        }
    }
}