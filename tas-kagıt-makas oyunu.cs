using System;

namespace taş_kağıt_makas_oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            tekrarla3:
            Console.Write("Sistem tas-kagit-makas 'dan birini tuttu, sıra sizde.");
            string[] dizi = { "tas", "kagit", "makas" };
            tekrarla:
            int degisken;

            Random rnd = new Random();
            degisken = rnd.Next(0, 3);

            string sistemtutulan = dizi[degisken];

            string kullanıcıtutulan;
            problem:
            Console.Write("Seçimin: ");
            kullanıcıtutulan = Console.ReadLine();

            if (kullanıcıtutulan=="tas"||kullanıcıtutulan=="kagit"||kullanıcıtutulan=="makas")
            {
                goto noproblem;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Lütefen taş,kağıt ve makas haricinde değer girmeyin");
                goto problem;
            }











            noproblem:
            if (sistemtutulan=="tas"&kullanıcıtutulan=="makas")
            {
                Console.WriteLine("");
                Console.WriteLine("KAYBETTİN-------Sistem: "+sistemtutulan+"    Siz: "+kullanıcıtutulan);
            }
            else if (sistemtutulan=="tas"&kullanıcıtutulan=="kagit")
            {
                Console.WriteLine("");
                Console.WriteLine("KAZANDIN-------Sistem: " + sistemtutulan + "    Siz: " + kullanıcıtutulan);
            }
            else if (sistemtutulan=="kagit"&kullanıcıtutulan=="makas")
            {
                Console.WriteLine("");
                Console.WriteLine("KAZANDIN-------Sistem: " + sistemtutulan + "    Siz: " + kullanıcıtutulan);
            }
            else if (sistemtutulan=="kagit"&kullanıcıtutulan=="tas")
            {
                Console.WriteLine("");
                Console.WriteLine("KAYBETTİN-------Sistem: " + sistemtutulan + "    Siz: " + kullanıcıtutulan);
            }
            else if (sistemtutulan=="makas"&kullanıcıtutulan=="tas")
            {
                Console.WriteLine("");
                Console.WriteLine("KAZANDIN-------Sistem: " + sistemtutulan + "    Siz: " + kullanıcıtutulan);
            }
            else if (sistemtutulan=="maksa"&kullanıcıtutulan=="kagit")
            {
                Console.WriteLine("");
                Console.WriteLine("KAYBETTİN-------Sistem: " + sistemtutulan + "    Siz: " + kullanıcıtutulan);
            }
            else if(sistemtutulan==kullanıcıtutulan)
            {
                Console.WriteLine("");
                Console.WriteLine("Sistemle aynı şeyi tuttunuz;lütfen tekrar tuttun: ");
                goto tekrarla;
            }

            Console.WriteLine("Tekrar oynamak istiyor musunuz Evet/e , Hayır/h");
            string soru;
            soru = Console.ReadLine();

            if (soru=="e"||soru=="E")
            {
                goto tekrarla3;
            }
            else
            {
                Console.WriteLine("Sistem Sonlandırıldı");
            }
        }
    }
}
