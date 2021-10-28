using System;

class Program
{
    public static void Main(string[] args)
    {
        int x;
        
        Console.WriteLine("lütfen sayıyı giriniz");
        
        x = (int) readValue();
        if (x > 0)
        {
            Console.WriteLine("pozitiftir");
        }
        else
        {
            if (x == 0)
            {
                Console.WriteLine("ne pozitif ne negatif");
            }
            else
            {
                Console.WriteLine("negatiftir");
            }
        }
    }
    

    