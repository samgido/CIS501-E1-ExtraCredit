using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Kindle
{
    internal class LibraryController
    {
        private Library _library;
        private SyncLibrary? _updateView;

        public LibraryController(Library library)
        {
            _library = library;
        }

        public void SetSyncLibrary(SyncLibrary syncLibrary)
        {
            _updateView = syncLibrary;
        }

        public void SyncLibrary()
        {
            _library.SyncLibrary();
            _updateView!();
        }
    }
}
