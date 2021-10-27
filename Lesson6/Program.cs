using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using Models;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[3]
            {
                    new Book("Math", "Library1", 200),
                    new Book("Biology", "Library1", 130),
                    new Book("English", "Library2", 100)
            };
            
            var library = new Library(books);
            Book book1 = library.InformationByIndex(2);
            book1.PrintBookInformation();
           

            var name = Console.ReadLine();
            Book book2 = library.GetBookByName(name);
            if (book2 != null)
            {
                book2.PrintBookInformation();
            }
            else
            {
                    Console.WriteLine("Such book doesn't exist");
            }

            Book book3 = library.FindTheBiggestBook();
            book3.PrintBookInformation();





        }
    }
}
