using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain
{
    public class Library
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public TimeOnly OpeningTime { get; private set; }
        public TimeOnly ClosingTime { get; private set; }
        List<Book> BookList;

        public Library(string name, string address, int openingHourHour, int openingHourMinute, int closingHourHour, int closingHourMinute)
        {
            Name = name;
            Address = address;
            OpeningTime = new TimeOnly(openingHourHour, openingHourMinute);
            ClosingTime = new TimeOnly(closingHourHour, closingHourMinute);
            BookList = new List<Book>();
        }

        public void AddBook(Book book)
        {
            BookList.Add(book);
        }

        public Book SearchBook(string title)
        {
            return BookList.Find(book => book.BookList.Contains(title));
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            return BookList.FindAll(book => book.BookList.Contains(author));
        }

        public int GetBooksCount()
        {
            return BookList.Count();
        }
    }
}
