using System;

 class Program
{
    public static void Main(string[] args)
    {
        double x, y, a, b, c, d;

        Console.WriteLine("x değerini yazınız");
        x = readValue();
        Console.WriteLine("y değerini yazınız");
        y = readValue();
        a = x * y;
        b = x / y;
        c = x + y;
        d = x - y;
        Console.WriteLine(x.ToString() + " * " + y + " = " + a);
        Console.WriteLine(x.ToString() + " / " + y + " = " + b);
        Console.WriteLine(x.ToString() + " + " + y + " = " + c);
        Console.WriteLine(x.ToString() + " - " + y + " = " + d);
    }
    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
