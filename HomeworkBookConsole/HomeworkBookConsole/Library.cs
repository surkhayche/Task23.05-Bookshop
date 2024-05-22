using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkBookConsole
{
    public class Library
    {
        public Book[] Books = new Book[0];

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length +1);
            Books[Books.Length -1] = book;

        }
        public Book GetBookById(int id)
        {
            foreach (var book in Books)
            {
                if (book.Id == id)
                {
                    return book;
                }
            }
            return null;
        }
        public Book GetBookByName(string name)
        {
            Book[] searchedBooks = Array.Empty<Book>();

            foreach (var book in Books)
            {
                if (book.Name == name)
                {
                    Array.Resize(ref searchedBooks, searchedBooks.Length + 1);
                    searchedBooks[Books.Length -1] = book;
                }
            }
            return null;

        }
        public Book GetFilteredBooks(string genreName)
        {
            Book[] searchedBooks = Array.Empty<Book>();
            foreach (var book in Books)
            {
                if (book.Genre == genreName)
                {
                    Array.Resize(ref searchedBooks, searchedBooks.Length - 1);
                    searchedBooks[Books.Length-1] = book;
                }
            }
            return null;//searchedBooks;
        }


    }
}
