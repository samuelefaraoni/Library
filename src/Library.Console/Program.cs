using Library.Console;
using System.Runtime.CompilerServices;

bool executionStatus = true;
Controller controller = new Controller();
Library library = new Library("Biblioteca Malatestiana", "Piazza Maurizio Bufalini 1. 47521 Cesena(FC)", 9, 0, 19, 0);

while (executionStatus == true)
{
    controller.ShowMenu();
    string choice = Console.ReadLine();

    switch(choice)
    {
        case "1":
            Console.WriteLine("Insert title");
            string title = Console.ReadLine();
            Console.WriteLine("Insert author");
            string author = Console.ReadLine();
            Console.WriteLine("Insert publication year");
            Int32.TryParse(Console.ReadLine(), out int result);
            int publicationYear = result;
            Console.WriteLine("Insert publisher");
            string publisher = Console.ReadLine();
            Console.WriteLine("Insertthe number of pages");
            Int32.TryParse(Console.ReadLine(), out int result2);
            int pages = result2;

            Book book = new Book(title, author, publicationYear, publisher, pages);

            library.BookList.Add(book);
            break;
        case "2":
            Console.WriteLine("Insert book title");
            string title = Console.ReadLine();
            library.SearchBook(title);
            break;
        case "3":
            Console.WriteLine("Insert book author");
            string author = Console.ReadLine();
            library.GetBooksByAuthor(author);
            break;
        case "4":
            library.GetBooksCount();
            break;
        case: "5":
            executionStatus = false;
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}