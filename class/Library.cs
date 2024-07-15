
public class Library{

    public List<Book> Books { get; private set; }

    public Library(){
        this.Books = new List<Book>();
    }

    public void AddBook(Book book) => this.Books.Add(book);
    public void ListBooks(){
        foreach (Book book in this.Books){
            string status = book.IsCheckedOut ? "Checked Out" : "Available";
            Console.WriteLine($"{book.Title} , {book.Author} - {status}");
        }
    }
    public void CheckOutBook(string title){
        Book? bookFind = this.Books.Find(book => book.Title == title);

        if (bookFind != null && !bookFind.IsCheckedOut){
            bookFind.CheckOut();
            Console.WriteLine($"You have checkd out '{title}'.");
        }
        else{
            Console.WriteLine($"'{title}' is not available.");
        }  
    }

    public void ReturnBook(string title){
        Book? bookFind = this.Books.Find(book => book.Title == title);

        if (bookFind != null && bookFind.IsCheckedOut){
            bookFind.Return();
            Console.WriteLine($"You have returned '{title}'.");
        }
        else{
            Console.WriteLine($"'{title}' is not checked out.");
        }  
    }
}

