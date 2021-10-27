using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Library
    {
        private Book[] _books;

        public Library(Book[] books)
        {
            _books = books;

        }
        
        public Book InformationByIndex(int index)
        {
            var book = _books[index];
            return book;
        }

        public Book GetBookByName (string name)
        {
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i].GetBookName() == name)
                {
                    return _books[i];
                }
            }

            return null;
        }
        public Book FindTheBiggestBook()
        {
            Book biggestBook = _books[0];
            for (int i = 1; i < _books.Length; i++)
            {
                if (biggestBook.GetBookPages() < _books[i].GetBookPages())
                {
                    biggestBook = _books[i];
                }
                
            }

            return null;
        }

    }

    

}
