namespace IntroConsoleApp;

public static class HelperFunctions
{

    public static void PrintRectangle(int a, int b, char sign = '*')
    {
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                Console.Write(sign);
            }

            Console.WriteLine();
        }

    }

    public static void SetTextColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }
}