


class Program{

    public static void Main(String[] args) {
        Library library = new Library();
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. List books");
            Console.WriteLine("3. Check out a book");
            Console.WriteLine("4. Return a book");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter the title of the book: ");
                    string? title = Console.ReadLine();

                    Console.Write("Enter the author of the book: ");
                    string? author = Console.ReadLine();

                    if(title.Length == 0 || author.Length == 0){
                        Console.WriteLine("Book not added, empty value.");
                        break;
                    }
                    library.AddBook(new Book(title, author));
                    Console.WriteLine("Book added successfully!\n");
                    break;

                case "2":
                    Console.WriteLine("List of Books:");
                    library.ListBooks();
                    Console.WriteLine();
                    break;

                case "3":
                    Console.Write("Enter the title of the book to check out: ");
                    title = Console.ReadLine();
                    if (title.Length == 0 ) {
                        Console.WriteLine();
                        break;
                    };
                    library.CheckOutBook(title);
                    Console.WriteLine();
                    break;

                case "4":
                    Console.Write("Enter the title of the book to return: ");
                    title = Console.ReadLine();
                    if (title.Length == 0 ) {
                        Console.WriteLine();
                        break;
                    };
                    library.ReturnBook(title);
                    Console.WriteLine();
                    break;

                case "5":
                    keepRunning = false;
                    Console.WriteLine("Exiting the program.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.\n");
                    break;
            }
        }
    }
}