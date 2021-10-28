using System;

 class Program
{
    public static void Main(string[] args)
    {
        int x, a, b, c, y, d, e;

        Console.WriteLine("lütfen sayı giriniz");
        x = (int)readValue();
        a = (int)Math.Pow(x % 10, 3);
        b = (int)((double)(x % 100) / 10);
        c = (int)Math.Pow(b, 3);
        d = (int)((double)x / 100);
        e = (int)Math.Pow(d, 3);
        y = a + c + e;
        if (y == x)
        {
            Console.WriteLine("sayı bir armstrong sayısıdır");
        }
        else
        {
            Console.WriteLine("armstrong sayısı değildir");
        }
    }
 private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
