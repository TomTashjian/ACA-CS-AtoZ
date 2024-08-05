using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Library : IEnumerable
    {
        private Book[] _bookshelf { get; set;}
        private int _currentIndex = -1;

        public Library()
        {
            _bookshelf = new Book[10];
        }

        public void AddBook(Book book)
        {
            _currentIndex++;
            if(_currentIndex >= _bookshelf.Length)
            {
                Book[] temp = new Book[_bookshelf.Length * 2];
                _bookshelf.CopyTo(temp, 0);
                _bookshelf = temp;
            }
            _bookshelf[_currentIndex] = book;
        }

        public IEnumerator GetEnumerator()
        {
            return new Librarian(_bookshelf);
        }
    }
}
