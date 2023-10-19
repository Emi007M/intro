using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOne;
internal static class Rectangle
{

    public static void CalculateRectangleField()
    {
        int width, height;
        int rectangleField;

        Console.WriteLine("Podaj szerokość prostokąta");
        width = int.Parse(Console.ReadLine());

        bool positiveValueCheck = IsPositiveValue(width);

        if (!positiveValueCheck)
        {
            Console.WriteLine("niepoprawna wartość");
        }

        Console.WriteLine("Podaj wysokość prostokąta");
        height = int.Parse(Console.ReadLine());

        Console.WriteLine("Pole prostokąta o bokach " + width + " " + height);

        //rectangleField = width * height
        rectangleField = CalcField(width, height) ;
        Console.WriteLine(rectangleField);

    } 

    public static bool IsPositiveValue(int value)
    {
        bool result = value > 0;

        return result;
    }


    public static int CalcField(int a, int b)
    {
        int x = a * b;
        return x;
    }



}
