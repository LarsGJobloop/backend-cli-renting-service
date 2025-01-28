Console.WriteLine("Starting Renting Service");

string? input = Console.ReadLine();
if (input == null)
{
  Environment.Exit(1);
}

Console.WriteLine("Echo: " + input);
