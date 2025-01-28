class RentingService
{
  private Dictionary<Book, int> bookInventory;
  private Dictionary<Book, int> currentlyBorrowed;

  public RentingService()
  {
    bookInventory = new Dictionary<Book, int>{
      { new Book("Martian", "Jim"), 10 },
      { new Book("Foundation", "Jack"), 30 },
    };
    currentlyBorrowed = new Dictionary<Book, int>();
  }

  public Dictionary<Book, int> ListAllBooks()
  {
    return bookInventory;
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