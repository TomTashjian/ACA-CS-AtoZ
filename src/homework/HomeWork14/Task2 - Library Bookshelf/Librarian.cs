using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Librarian : IEnumerator
    {
        private Book[] _bookshelf { get; set; }

        public object? Current { get; private set; }

        private int _currentIndex = -1;

        public Librarian(Book[] bookshelf)
        {
            _bookshelf = bookshelf;
        }

        public bool MoveNext()
        {
            if(_currentIndex >= _bookshelf.Length)
            {
                return false;
            }
            else
            {
                _currentIndex++;
                if (_bookshelf[_currentIndex] == null)
                {
                    return false;
                }
                Current = _bookshelf[_currentIndex];
                return true;
            }
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
    }
}
