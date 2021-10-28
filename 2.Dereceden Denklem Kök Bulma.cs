using System;

 class Program
{
    public static void Main(string[] args)
    {
        int a, b, c, delta, kök1, kök2;

        Console.WriteLine("x^2'nin katsayısını giriniz");
        a = (int)readValue();
        Console.WriteLine("x'in katsayısını giriniz");
        b = (int)readValue();
        Console.WriteLine("sabit değeri giriniz");
        c = (int)readValue();
        delta = b * b - 4 * a * c;
        kök1 = (int)((-b - Math.Pow(delta, (double)1 / 2)) / 2 * a);
        kök2 = (int)((-b + Math.Pow(delta, (double)1 / 2)) / 2 * a);
        if (delta > 0)
        {
            Console.WriteLine("iki farklı kök vardır:");
            Console.WriteLine(kök1.ToString() + " ve " + kök2);
        }
        else
        {
            if (delta == 0)
            {
                Console.WriteLine("birbirine eşit iki kök vardır:");
                Console.WriteLine(kök1);
            }
            else
            {
                Console.WriteLine("reel kök yoktur");
            }
        }
    }


    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
