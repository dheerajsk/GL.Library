using GL.Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http.ModelBinding;

namespace GL.Library
{
    class RequestHandler
    {
        public void GetByGenre()
        {
            // In coming projects we will use DI to get instance of other classes.

            Console.WriteLine("Enter genre");
            string genre = Console.ReadLine();
            var result = new BookRepository().GetByGenre(genre);
            this.DisplayResult(result);
        }

        public Book Add()
        {
            Console.WriteLine("Enter book name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter book author");
            string author = Console.ReadLine();
            Console.WriteLine("Enter book genre");
            string genre = Console.ReadLine();
            Book book = new Book(name, author, genre, 0);
            return new BookRepository().Add(book);
        }

        public void SearchByName()
        {
            Console.WriteLine("Enter book name");
            string name = Console.ReadLine();
            var result = new BookRepository().GetByName(name);
            this.DisplayResult(result);
        }

        private void DisplayResult(IEnumerable<Book> result)
        {

            if (result.Count() == 0)
            {
                Console.WriteLine("\nNo matching books found\n");
            }
            else
            {
                Console.WriteLine($"\n({result.Count()}) books found\n");
                foreach (Book book in result)
                {
                    Console.WriteLine($"Name: {book.Name} | Author: {book.Author} | Genre: {book.Genre} | Rating : {book.Rating}");
                }
            }
        }
    }
}
