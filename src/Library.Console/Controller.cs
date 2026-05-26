using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Console
{
    public class Controller
    {
        public string ShowMenu()
        {
            return ("1) Create and add book to library./n2) Search book by title./n3) Search book by author./n 4) Return book count./n5) Exit program.");
        }
    }
}
