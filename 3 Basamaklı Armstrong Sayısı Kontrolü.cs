using System;

 class Program
{
    public static void Main(string[] args)
    {
        int girilenSayı, k, t, s;

        Console.WriteLine("Sayının Armstrong sayı olup/olmadığı kontrol edilecektir,Sayı giriniz...");
        girilenSayı = (int)readValue();
        s = girilenSayı;
        t = 0;
        while ((double)girilenSayı / 10 != 0)
        {
            k = girilenSayı % 10;
            t = (int)(t + Math.Pow(k, 3));
            girilenSayı = (int)((double)girilenSayı / 10);
        }
        if (s == t)
        {
            Console.WriteLine("armstrong sayıdır");
        }
        else
        {
            Console.WriteLine("armstrong sayı değildir");
        }
    }


    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
