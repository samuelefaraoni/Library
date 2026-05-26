using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int PublicationYear { get; private set; }
        public string Publisher { get; private set; }
        public int Pages { get; private set; }

        public Book(string title, string author, int publicationYear, string publisher, int pages)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Publisher = publisher;
            Pages = pages;
        }

        public string ToString()
        {
            return ($"Title: {Title}. Author: {Author}. Publication Year: {PublicationYear}. Publisher: {Publisher}. Pages: {Pages}");
        }

        public string ReadingTime()
        {
            switch(Pages)
            {
                case < 100:
                    return "Reading time: 1 hour";
                    break;
                case >= 00 and <= 200:
                    return "Reading time: 2 hours";
                    break;
                case > 200:
                    return "Reading time: Greater than 2 hours";
                    break;
                default:
                    return "Error";
                    break;
            }
        }
    }
}
