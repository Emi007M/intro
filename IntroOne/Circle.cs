
namespace IntroOne;
internal static class Circle
{
    public static void CalculateField()
    {
        int r;
        double field;

        Console.WriteLine("Podaj wartość r");
        r = int.Parse(Console.ReadLine());

        Console.WriteLine("Pole koła o promieniu " + r);
        field = Calculate(r);
        Console.WriteLine(field);
    }
    public static double Calculate(int r)
    {
        double pi = Math.PI;
        double r2 = Math.Pow(r, 2);

        double x = r2 * pi;
        return x;
    }

}
