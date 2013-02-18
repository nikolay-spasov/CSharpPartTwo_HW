using System;

class SrufaceOfATriangle
{
    static void Main()
    {
        Console.WriteLine("Calculate triangle surface by: ");
        Console.WriteLine("A) Side and atitude.");
        Console.WriteLine("B) Three sides.");
        Console.WriteLine("C) Two sides and the angle between them.");
        Console.WriteLine("Press A, B or C");

        string input = Console.ReadLine();

        double surface = 0d;
        double a, b, c;

        switch (input)
        {
            case "A":
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("h = ");
                double h = double.Parse(Console.ReadLine());
                
                surface = CalculateTriangleSurface(a, h);
                Console.WriteLine("Suface = {0}", surface);

                break;
            case "B":
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                c = double.Parse(Console.ReadLine());
                
                surface = CalculateTriangleSurface(a, b, c);
                Console.WriteLine("Surface = {0}", surface);

                break;
            case "C":
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = double.Parse(Console.ReadLine());
                Console.Write("angle = ");
                double angle = double.Parse(Console.ReadLine());
                
                surface = CalculateTriangleSurfaceByTwoSidesAndAngle(a, b, angle);

                Console.WriteLine("Surface = {0}", surface);
                break;
            default:
                Console.WriteLine("You must enter A, B or C.");
                break;
        }
    }

    private static double CalculateTriangleSurface(double a, double h)
    {
        return (a * h) / 2;
    }

    private static double CalculateTriangleSurface(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double temp = p * (p - a) * (p - b) * (p - c);
        return Math.Sqrt(temp);
    }

    private static double CalculateTriangleSurfaceByTwoSidesAndAngle(
        double a, double b, double angle)
    {
        return (a * b * Math.Sin(angle) / 2);
    }
}

