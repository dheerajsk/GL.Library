using GL.Library.Repository;
using System;
using System.Linq;

namespace GL.Library
{
    class Program
    {
        public static bool IsLoggedIn { get; set; }

        static void Main(string[] args)
        {
            int option = 0;
            while (option != 5)
            {
                Console.Write("\n");
                Console.WriteLine("1. Login");
                if (IsLoggedIn)
                {
                    Console.WriteLine("2. Add a book");
                }
                Console.WriteLine("3. Search by Name");
                Console.WriteLine("4. Search by Genre");
                Console.WriteLine("5. Exit");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter admin password");
                        string password = Console.ReadLine();
                        if (password.Equals("admin"))
                        {
                            IsLoggedIn = true;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect password");
                        }
                        break;
                    case 2:
                        if (!IsLoggedIn)
                        {
                            Console.WriteLine("Invalid Command");
                            break;
                        }
                        new RequestHandler().Add();
                        Console.WriteLine("Book added to Library");
                        break;
                    case 3:
                        new RequestHandler().SearchByName();
                        break;
                    case 4:
                        new RequestHandler().GetByGenre();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;

                }

            }
        }
    }
}
