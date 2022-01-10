using System;

namespace BinaryÇevirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çevrilicek binary sayıyı girin");

            string binary = Console.ReadLine();
            int a = Convert.ToInt32(binary.Substring(0, 1));
            int b = Convert.ToInt32(binary.Substring(1, 1));
            int c = Convert.ToInt32(binary.Substring(2, 1));
            int d = Convert.ToInt32(binary.Substring(3, 1));

            a = a * 8;
            b = b * 4;
            c = c * 2;
            d = d * 1;

            int toplam = a + b + c + d;

            Console.WriteLine("Karşılığı: " + toplam);
        }
    }
}
