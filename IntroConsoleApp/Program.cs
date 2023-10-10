using static IntroConsoleApp.HelperFunctions;

Console.WriteLine("Hello, World!");


SetTextColor(ConsoleColor.Green);
PrintRectangle(5, 10);

SetTextColor(ConsoleColor.Magenta);
PrintRectangle(5, 30, 'X');


Console.ReadKey();