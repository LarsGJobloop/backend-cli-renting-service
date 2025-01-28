class RentingService
{
  private Dictionary<Book, int> bookInventory;
  private Dictionary<Book, int> currentlyBorrowed;

  public RentingService()
  {
    bookInventory = new Dictionary<Book, int>{
      { new Book("Martian", "Jim"), 2 },
      { new Book("Foundation", "Jack"), 30 },
    };
    currentlyBorrowed = new Dictionary<Book, int>{
      { new Book("Martian", "Jim"), 0 },
      { new Book("Foundation", "Jack"), 0 },
    };
  }

  public Dictionary<Book, int> ListAllBooks()
  {
    return bookInventory;
  }

  public BorrowReciept? BorrowBook(string bookTitle)
  {
    // Vi må finne om vi har booken
    Book? book = bookInventory
      .Where((entry) => entry.Key.Title == bookTitle) // Finne elementen som har samme tittel
      .First() // Ta først elementet
      .Key; // Ta booken, ignore antall

    // Viss vi ikke har boken registrert return ingeneting
    if (book == null)
    {
      return null;
    }

    // Vi må finne ut om vi har minst en bok tilgjengelig
    currentlyBorrowed.TryGetValue(book, out int amountBorrowed);
    bookInventory.TryGetValue(book, out int amountInInventory);
    bool isAvailable = amountInInventory - amountBorrowed > 0;

    if (!isAvailable)
    {
      // Vi har ikke eksampler tilgjengelig
      return null;
    }
    else
    {
      // Lage en ny kvittering
      BorrowReciept reciept = new BorrowReciept(bookTitle);
      // Oppdater utlånt listen vår
      currentlyBorrowed[book] = amountBorrowed + 1;
      // Returnere kvittering
      return reciept;
    }
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
  public DateTime BorrowedDate;
  public DateTime ReturnDate;
  public String BookTitle;

  public BorrowReciept(string bookTitle)
  {
    BookTitle = bookTitle;
    BorrowedDate = DateTime.Now;
    ReturnDate = new DateTime().AddMonths(1);
  }
}

class ReturnReciept
{

}