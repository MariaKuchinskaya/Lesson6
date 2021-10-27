using System;

namespace Models
{
    public class Book
    {
        private string _name;
        private string _libraryName;
        private int _pagesCount;

        public Book(string name, string libraryName, int pagesCount)
        {
            _name = name;
            _libraryName = libraryName;
            _pagesCount = pagesCount;
        }

        public void PrintBookInformation()
        {
            Console.WriteLine($"Book name: {_name}");
            Console.WriteLine($"Library name: {_libraryName}");
            Console.WriteLine($"Pages count: {_pagesCount}");
        }

        public string GetBookName()
        {
            return _name;
        }
    }
}
