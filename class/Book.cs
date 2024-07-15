
public class Book{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsCheckedOut { get; set; }

    public Book(string title, string author){
        this.Title = title;
        this.Author = author;
        this.IsCheckedOut = false;
    }

    public void CheckOut() => this.IsCheckedOut = true;
    public void Return() => this.IsCheckedOut = false;

} 