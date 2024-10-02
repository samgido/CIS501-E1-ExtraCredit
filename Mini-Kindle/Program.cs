namespace Mini_Kindle
{
    public delegate void SyncLibrary();
    public delegate void GetBooks();
    public delegate void ToggleBookmark(int page);
    public delegate void OpenBook(Book book);
    public delegate void ChangePage(int page);
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
            Library l = new Library();
            l.AddBook(b1);
            l.AddBook(b2);
            LibraryController lc = new LibraryController(l);
            BookController bc = new BookController();

            Application.Run(new LibraryView());
        }
    }
}