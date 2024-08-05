/*
Library Bookshelf:
Imagine a library with many bookshelves. Each bookshelf contains books (our attractions).
The entire library represents a collection of attractions.
IEnumerable is like a librarian who hands you one book at a time (using an IEnumerator).
You can read each book (access its content) without loading the entire library into memory.
 */
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            for (int i = 0; i < 15; i++)
                library.AddBook(new Book { Title = $"Book{i}"});

            foreach (Book book in library)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
