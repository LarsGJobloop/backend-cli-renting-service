Console.WriteLine("Starting Renting Service");

RentingService rentingService = new RentingService();

while (true)
{
  string? input = Console.ReadLine();
  if (input == null)
  {
    Environment.Exit(1);
  }

  switch (input)
  {
    case "list":
      Dictionary<Book, int> availableBooks = rentingService.ListAllBooks();
      foreach (var bookEntry in availableBooks)
      {
        Console.WriteLine(bookEntry.Key.Title);
      }
      break;
    case "borrow":
      string? bookTitleInput = Console.ReadLine();
      if (bookTitleInput == null)
      {
        Environment.Exit(1);
      }

      BorrowReciept? reciept = rentingService.BorrowBook(bookTitleInput);

      if (reciept == null)
      {
        Console.WriteLine($"No books with title {bookTitleInput} available");
      }
      else
      {
        Console.WriteLine("Congratulation, book borrowed");
      }

      break;
    case "return":
      Console.WriteLine("Returning book");
      break;
    default:
      Console.WriteLine("Invalid Input");
      break;
  }
}
