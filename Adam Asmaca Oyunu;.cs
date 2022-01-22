using System;

namespace AdamAsmacaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kelimeler = { "ıspanak", "karnabahar", "brokoli", "maydanoz", "vişne", "ahududu", "avakado", "hurma", "böğürtlen", "bilgisayar", "kanepe", "çaydanlık", "eldiven", "askılık", "fincan", "kaplumbağa", "kanguru", "karınca", "zürafa", "tavşan", "yarasa" };
            string secilenKelime;
            int hak = 7;
            Random rnd = new Random();
            secilenKelime = kelimeler[rnd.Next(0, kelimeler.Length - 1)];
            char[] yertutucu = new char[secilenKelime.Length];

            for (int i = 0; i < yertutucu.Length; i++)
            {
                yertutucu[i] = '-';
                Console.Write('-');
            }
            Console.WriteLine();

            while (true)
            {
                if (secilenKelime == "ıspanak" || secilenKelime == "karnabahar" || secilenKelime == "brokoli" || secilenKelime == "maydanoz")
                {
                    Console.WriteLine("Kategori: SEBZE");
                }
                else if (secilenKelime == "vişne" || secilenKelime == "avakado" || secilenKelime == "böğürtlen" || secilenKelime == "ahududu" || secilenKelime == "hurma")
                {
                    Console.WriteLine("Kategori: MEYVE");
                }
                else if (secilenKelime == "bilgisayar" || secilenKelime == "kanepe" || secilenKelime == "çaydanlık" || secilenKelime == "eldiven" || secilenKelime == "askılık" || secilenKelime == "fincan")
                {
                    Console.WriteLine("Kategori: EŞYA");
                }
                else if (secilenKelime == "kamlumbağa" || secilenKelime == "kanguru" || secilenKelime == "karınca" || secilenKelime == "zürafa" || secilenKelime == "tavşan" || secilenKelime == "yarasa")

                {
                    Console.WriteLine("Kategori: HAYVAN");
                }



                Console.WriteLine("Kalan Hak:{0}", hak);
                Console.Write("Bir harf girin   :");
                char harf = Convert.ToChar(Console.ReadLine());

                bool bayrak = false;
                int kalanKelime = 0;

                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    if (secilenKelime[i] == harf)
                    {
                        yertutucu[i] = harf;
                        bayrak = true;
                    }
                    if (yertutucu[i] == '-')
                    {
                        kalanKelime++;
                    }
                    Console.Write(yertutucu[i]);
                }
                Console.WriteLine();

                if (kalanKelime == 0)
                {
                    Console.WriteLine("TEBRİKLER...");
                    Console.WriteLine("******************");
                    break;
                }

                if (bayrak == false)
                {
                    hak = hak - 1;
                }

                if (hak == 0)
                {
                    Console.WriteLine("Üzgünüm kaybettiniz.");
                    break;
                }

                Console.WriteLine("******************");
            }

            Console.Write("Seçilen kelime>>> " + secilenKelime + " <<<");
            Console.ReadLine();













        }
    }
}
