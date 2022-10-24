// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hi! What's your name?");
var name = Console.ReadLine();
Console.WriteLine($"{Environment.NewLine}Nice to meet you, {name}!");
Console.Write($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);
