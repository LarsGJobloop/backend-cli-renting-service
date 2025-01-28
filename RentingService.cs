class RentingService
{
  private Dictionary<Book, int> bookInventory;
  private Dictionary<Book, int> currentlyBorrowed;

  public RentingService()
  {
    bookInventory = new Dictionary<Book, int>();
    currentlyBorrowed = new Dictionary<Book, int>();
  }

  public void ListAllBooks()
  {
    Console.WriteLine("Listing out books");
  }
}

class Book
{
  public string Title;
  public string Author;

  public Book(string title, string author)
  {
    Title = title;
    Author = author;
  }
}

class BorrowReciept
{

}

class ReturnReciept
{

}