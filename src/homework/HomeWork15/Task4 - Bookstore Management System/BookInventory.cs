using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class BookInventory
    {
        private List<Book> _books;

        public BookInventory()
        {
            _books = new List<Book>();
        }

        public void Add(Book book)
        {
            _books.Add(book);
        }
    }
}
