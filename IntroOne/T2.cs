namespace IntroOne;
internal static class T2
{
    public static void Main()
    {
        //reading user input and evaluating it

        Console.WriteLine("Podaj liczbę całkowitą");

        var userInput = Console.ReadLine();
        var number = int.Parse(userInput);

        int min = 0, max = 100;

        if(number < max &&  number > min)
        {
            Console.WriteLine("Liczba należy do przedziału od " + min + " do " + max);
        } else
        {
            Console.WriteLine($"Liczba nie należy do przedziału od {min} do {max}");
        }

        Console.WriteLine();



        // -- string operations

        var txt = "text dlugi";

        var result = txt.Substring(3); // returns substring of string txt starting from 3rd letter (counting from 0)
        Console.WriteLine(result);

        var result2 = txt.IndexOf('x'); // returns index position of the first occurence of character 'x' in txt string
        Console.WriteLine(result2);

        var letterIndex = txt.IndexOf('d');
        var result3 = txt.Substring(letterIndex); // returns substring of string txt starting from letter 'd';
        //var result3 = txt.Substring(txt.IndexOf('d'));
        Console.WriteLine(result3);

        var result4 = txt.Substring(0, txt.Length - 2); // returns substring of string txt shorten from the end by 2 characters
        Console.WriteLine(result4);


    }
}
