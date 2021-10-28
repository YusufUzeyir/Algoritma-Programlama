using System;

 class Program
{
    public static void Main(string[] args)
    {
        int x, y;

        Console.WriteLine("ilk sayıyı giriniz");
        x = (int)readValue();

        Console.WriteLine("ikinci sayıyı giriniz");
        y = (int)readValue();

        if (x == y)
        {
            Console.WriteLine(x.ToString() + " = " + y);
        }
        else
        {
            if (x > y)
            {
                Console.WriteLine(x.ToString() + " > " + y);
            }
            else
            {
                Console.WriteLine(x.ToString() + " < " + y);
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
