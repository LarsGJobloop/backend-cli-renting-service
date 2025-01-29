class RentingService
{
  private Dictionary<Book, int> bookInventory;
  private Dictionary<Book, int> currentlyBorrowed;

  public RentingService()
  {
    // Lage ett sett med bøker
    Book martian = new Book("Martian", "Jim");
    Book foundation = new Book("Foundation", "Jack");

    // Opprette data strukturen
    bookInventory = new Dictionary<Book, int>();
    currentlyBorrowed = new Dictionary<Book, int>();

    // Legg til bøker med antall
    bookInventory.Add(martian, 10);
    currentlyBorrowed.Add(martian, 0);
    bookInventory.Add(foundation, 2);
    currentlyBorrowed.Add(foundation, 0);
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