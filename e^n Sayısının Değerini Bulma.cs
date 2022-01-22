using System;

namespace Taylor_Maclourin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("e^x değeri hesaplacaktır lütfen x değerini girin: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double sonuc = taylor(x);
            Console.WriteLine("e^"+x+"= "+sonuc);
        }

        public static double taylor(double a)
        {
            double hesaplanan = 0;

            for (int i = 1; i <= 15; i++)
            {
                hesaplanan = hesaplanan + ((Math.Pow(a,i)) / faktöriyel(i));
            }
            hesaplanan = hesaplanan + 1;
            return hesaplanan;
        }
       
        public static int faktöriyel(int a)
        {
            int fakt = 1;
            for (int i = a; i > 0; i--)
            {
                fakt = fakt * i;
            }
            return fakt;
        }
        
    }
}
