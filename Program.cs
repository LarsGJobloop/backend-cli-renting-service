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
      rentingService.ListAllBooks();
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
