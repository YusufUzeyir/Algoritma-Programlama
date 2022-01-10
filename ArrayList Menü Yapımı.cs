using System;
using System.Collections;

namespace ArrayListMenüYapımı
{
    class Program
    {

        static void Main(string[] args)
        {
            string kullanıcısecimi = "";
            ArrayList degerlistesi = new ArrayList();

            do
            {
                Console.Clear();
                Console.WriteLine("Menü");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Değer Ekle");
                Console.WriteLine("2 - Değer Listele");
                Console.WriteLine("3 - Değer Ara");
                Console.WriteLine("4 - Değer Düzenle");
                Console.WriteLine("5 - Değer Sil");
                Console.WriteLine("6 - A-Z Sırala");
                Console.WriteLine("7 - Z-A Sırala");
                Console.WriteLine("8 - Uygulama Çıkış");
                Console.WriteLine(" ");
                Console.Write("Seçiniz: ");

                kullanıcısecimi = Console.ReadLine();


                switch (kullanıcısecimi)
                {
                    case "1":
                        Console.Write("Lütfen eklemek istediğiniz değeri giriniz: ");
                        string kullanıcıdeger = Console.ReadLine();

                        degerlistesi.Add(kullanıcıdeger);
                        Console.WriteLine("Değeriniz başarılı bir şekilde eklendi");
                        break;

                    case "2":
                        for (int i = 0; i < degerlistesi.Count; i++)
                        {
                            Console.WriteLine("{0}. Deger = {1}", i, degerlistesi[i]);
                        }
                        Console.WriteLine("Devam etmek için bir tuşa basım");
                        Console.ReadLine();
                        break;



                    case "3":
                        Console.WriteLine("Aramak istediğiniz değeri girin: ");
                        string aranacakdeger = Console.ReadLine();
                        bool kontrol = degerlistesi.Contains(aranacakdeger);
                        if (kontrol = true)
                        {
                            Console.WriteLine("Aradığınız Değer koleksiyonda var.");
                        }
                        else
                        {
                            Console.WriteLine("Aradığınız değer koleksiyonda yok.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Düzenlemek istediğiniz değeri girin: ");
                        string düzenlenecekdeger = Console.ReadLine();
                        int indexdegeri = degerlistesi.IndexOf(düzenlenecekdeger);
                        Console.WriteLine("Yerine yazılacak degeri giriniz: ");
                        string yenideger = Console.ReadLine();
                        degerlistesi[indexdegeri] = yenideger;
                        Console.WriteLine("Tebrikler " + düzenlenecekdeger + " değeri, " + yenideger + " olarak değiştirildi.");
                        break;

                    case "5":
                        Console.WriteLine("Silmek istediğiniz degeri girin: ");
                        string silinecekdeger = Console.ReadLine();
                        degerlistesi.Remove(silinecekdeger);
                        Console.WriteLine("Tebrikler " + silinecekdeger + " değerini sildiniz.");
                        break;


                    case "6":
                        degerlistesi.Sort();
                        for (int i = 0; i < degerlistesi.Count; i++)
                        {
                            Console.WriteLine("{0}. Deger = {1}", i, degerlistesi[i]);
                        }
                        Console.WriteLine("Devam etmek için bir tuşa basım");
                        Console.ReadLine();
                        break;

                    case "7":
                        degerlistesi.Sort();
                        degerlistesi.Reverse();
                        for (int i = 0; i < degerlistesi.Count; i++)
                        {
                            Console.WriteLine("{0}. Deger = {1}", i, degerlistesi[i]);
                        }
                        Console.WriteLine("Devam etmek için bir tuşa basım");
                        Console.ReadLine();
                        break;




                    default:
                        break;
                }

            } while (Convert.ToInt32(kullanıcısecimi) != 8);







        }
    }
}