namespace IntroOne;
internal static class T1
{
    public static void Main()
    {

        //variables initialization
        var greeting = "Hello everyone";
        var sign = '+';
        char sign2 = '3';


        //printing text
        Console.Write("Hello world!");
        Console.Write("\n");
        Console.WriteLine("Hello" + " " + "world");
        Console.WriteLine(greeting + "\n");


        /* using functions without and with parameters, 
         * retrieving user input (ReadLine), 
         * simple math calculations, 
         * user input basic validation (if conditions)*/
        Rectangle.CalculateRectangleField();
        Console.WriteLine();

        //using libraries (Math)
        Circle.CalculateField();
        Console.WriteLine();


        //--simple loops

        //print numbers <0;4>
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        //print rectangle 7x3
        for (int i = 0; i < 7; i++)
        {
            // Console.WriteLine("XXX");

            for (int j = 0; j < 3; j++)
                Console.Write("X");

            Console.WriteLine(); //or Console.Write("\n");
        }

    }
}
