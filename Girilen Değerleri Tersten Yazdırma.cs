using System;

namespace terstenYazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime = Console.ReadLine();

            for (int i = kelime.Length - 1; i >= 0; i--)
            {
                Console.Write(kelime[i]);
            }
            Console.ReadLine();
        }
    }
}
