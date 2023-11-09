namespace IntroOne;
internal static class T2_Exercises
{
    public static void Main()
    {
        // -- string operations exercises

        // 1 compare length of two strings
        string string1 = "lalka", string2 = "dom";
        CompareStringsLength(string1, string2);

        Console.WriteLine();

        // 2 replace text in a sentence
        string name1 = "Ala", name2 = "Tomek";
        var sentence = name1 + " ma kota";

        Console.WriteLine(sentence);
        Console.WriteLine(sentence.Replace(name1, name2));

        Console.WriteLine();

        // 3 modify text
        string text1 = "Ala ma Kota a kot ma ALĘ";
        Console.WriteLine(text1);
        Console.WriteLine(text1.ToUpper());

        Console.WriteLine();

        // 4 check character on given position
        string text2 = "Ala ma Kota a kot ma ALĘ";
        var charFromText = text2[7];

        if(char.IsUpper(charFromText))
        {
            Console.WriteLine(charFromText + " - to wielka litera");
        }
        else
        {
            Console.WriteLine(charFromText + " - to nie jest wielka litera");
        }

        Console.WriteLine();

    }

    private static void CompareStringsLength(string string1, string string2)
    {
        //version 1
        if (string1.Length > string2.Length)
        {
            Console.WriteLine($"słowo {string1} jest dłuższe od {string2}");
        }
        else if (string1.Length < string2.Length)
        {
            Console.WriteLine($"słowo {string1} jest krótsze od {string2}");
        }
        else
        {
            Console.WriteLine($"słowa {string1} i {string2} są równej długości");
        }

        //version 2
        if (string1.Length > string2.Length)
        {
            Console.WriteLine($"{string1} jest dłuższe od {string2}");
        }
        else
        {
            if (string1.Length < string2.Length)
            {
                Console.WriteLine($"{string1} jest krótsze od {string2}");
            }
            else
            {
                Console.WriteLine($"{string1} i {string2} są równej długości");
            }
        }

    }
}
