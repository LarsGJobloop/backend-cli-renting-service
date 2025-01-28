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
      Console.WriteLine("Borrowing book");
      break;
    case "return":
      Console.WriteLine("Returning book");
      break;
    default:
      Console.WriteLine("Invalid Input");
      break;
  }
}
