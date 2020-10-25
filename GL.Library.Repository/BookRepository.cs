using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GL.Library.Repository
{
    /// <summary>
    /// This is a static repo, in  coming projects we will create EFCOre repository which will connect to an inmemory db.
    /// </summary>
    public class BookRepository
    {
        private static List<Book> Books;

        static BookRepository()
        {
            Books = new List<Book>();
            SeedBooks();
        }

        private static void SeedBooks()
        {
            Books.Add(new Book(1, "Long Walk to Freedom", "Nelson Mandela", "Autobiography", 4.33));
            Books.Add(new Book(2, "My Expirements with Truth", "M K Gandhi", "Autobiography", 4.08));
            Books.Add(new Book(3, "When Breath becomes Air", "Paul Kalanithi", "Autobiography", 4.36));
            Books.Add(new Book(4, "The Alchemist", "Paulo Coelho", "Classics", 3.88));
            Books.Add(new Book(5, "To Kill a Mocking Bird", "Harper Lee", "Classics", 4.28));
            Books.Add(new Book(6, "Catcher in the Rye", "J D Slingar", "Classics", 3.81));
            Books.Add(new Book(7, "Pride and Prejudice", "Jane Austen", "Classics", 4.33));
            Books.Add(new Book(8, "1984", "George Orwell", "Classics", 4.36));
            Books.Add(new Book(9, "A Short History of Nearly Everything", "Bill Bryson", "NonFiction", 4.20));
            Books.Add(new Book(10, "A Brief History of Time", "Stephen Hawking", "NonFiction", 4.18));
            Books.Add(new Book(11, "A Brief History of Humankind", "Yuval Noah Harari", "NonFiction", 4.21));
        }

        public IEnumerable<Book> GetByName(string name)
        {
            return Books.Where(i => i.Name.ToLower().Contains(name.ToLower()));
        }

        public IEnumerable<Book> GetByGenre(string genre)
        {
            return Books.Where(i => i.Genre.ToLower().Contains(genre.ToLower()));
        }

        public Book Add(Book book)
        {
            var existingMaxID = Books.Select(i => i.ID).Max();
            book.ID = existingMaxID;
            Books.Add(book);
            return book;
        }
    }
}
