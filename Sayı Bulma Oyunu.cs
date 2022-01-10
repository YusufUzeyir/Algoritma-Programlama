using System;

namespace SayıBulmaYeniVersiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            #region KURALLAR BÖLÜMÜ;
            Console.WriteLine("!KURALLAR!");
            Console.WriteLine("---------------");
            Console.WriteLine("1-) Eğer sayı yazdıkran sonra altında hiçbir şey çıkmazsa hiçbir rakam tutulan sayıda bulunmuyor demektir");
            Console.WriteLine("2-) Eğer + işareti çıkarsa girilen sayının içerisinden 1 sayı doğru yerinde demektir");
            Console.WriteLine("3-) Eğer - işareti çıkarsa girilen sayının içerisinden 1 rakam tutulan sayıda var ama yeri farklı demektir");
            Console.WriteLine("");
            #endregion;

        #region OYUN KOD KISMI ;
        tekrarla:
            int x, rastgele, birler1, onlar1, yüzler1, binler1,sayac;
            sayac = 1;
            
            Random rnd = new Random();
            rastgele = rnd.Next(1000, 10000); // 4 basamaklı rastgele sayının random tutulması
            Console.WriteLine("4 Basamaklı sayı tutuldu,tahmin etmeye başlayabilirsiniz: ");
            Console.WriteLine("");

            int birler = rastgele % 10;                 //rastgele sayının basamak değerlerinin hesaplanması
            int onlar = ((rastgele % 100) / 10);
            int yüzler = ((rastgele % 1000) / 100);
            int binler = (rastgele / 1000);

            while (birler==onlar||birler==yüzler||birler==binler||onlar==yüzler||onlar==binler||yüzler==binler) 
                //rastgele sayıda aynı rakam içermesi halinde tekrar rastgele sayı tutulması
            {
                 rastgele = rnd.Next(1000, 10000);

                 birler = rastgele % 10;
                 onlar = ((rastgele % 100) / 10);
                 yüzler = ((rastgele % 1000) / 100);
                 binler = (rastgele / 1000);
            }

            x = Convert.ToInt32(Console.ReadLine()); //kullanıcıdan 4 basamaklı sayı tahmini alınması 

            while (x < 1000 || x >= 10000) //tahmin edilen sayının 4 basamaklı olup/olmaması kontrolü
            {
                Console.WriteLine("Lütfen 4 basamaklı bir değer girin.");
                Console.WriteLine("");
                x = Convert.ToInt32(Console.ReadLine());
            }

            birler1 = x % 10;                //girilen sayının basamak değerlerinin hesaplanması
            onlar1 = ((x % 100) / 10);
            yüzler1 = ((x % 1000) / 100);
            binler1 = (x / 1000);

            while (x != rastgele) //girilen sayının tutulan sayıya eşit olup/olmaması kontorlü
            {
                if (birler1 == birler || birler1 == onlar || birler1 == yüzler || birler1 == binler) //birler basamağını içerip/içermemesi kontorlü
                {
                    if (birler1==birler) //rakamın yeri kontorlü
                    {
                        Console.Write("+");
                    }
                    else if (birler1 == onlar || birler1 == yüzler || birler1 == binler)
                    {
                        Console.Write("-");
                    }
                    
                }
                

                if (onlar1 == birler || onlar1 == onlar || onlar1 == yüzler || onlar1 == binler)  //onlar basamağını içerip/içermemesi kontorlü
                {
                    if (onlar1==onlar) //rakamın yeri kontorlü
                    {
                        Console.Write("+");
                    }
                    else if (onlar1 == birler || onlar1 == yüzler || onlar1 == binler)
                    {
                        Console.Write("-");
                    }
                   
                }
                

                if (yüzler1 == birler || yüzler1 == onlar || yüzler1 == yüzler || yüzler1 == binler)  //yüzler basamağını içerip/içermemesi kontorlü
                {
                    if (yüzler1==yüzler) //rakamın yeri kontorlü
                    {
                        Console.Write("+");
                    }
                    else if (yüzler1 == birler || yüzler1 == onlar || yüzler1 == binler)
                    {
                        Console.Write("-");
                    }
                    

                }
                

                if (binler1 == birler || binler1 == onlar || binler1 == yüzler || binler1 == binler)  //binler basamağını içerip/içermemesi kontorlü
                {
                    if (binler1==binler) //rakamın yeri kontorlü
                    {
                        Console.WriteLine("+");
                    }
                    else if (binler1 == birler || binler1 == onlar || binler1 == yüzler)
                    {
                        Console.WriteLine("-");
                    }
                    
                }
                
                Console.WriteLine("");
                x = Convert.ToInt32(Console.ReadLine()); //kullanıcıdan tekrar sayı isteme

                birler1 = x % 10;                    //girilen sayının basamak değerlerinin tekrar hesaplanması
                onlar1 = ((x % 100) / 10);
                yüzler1 = ((x % 1000) / 100);
                binler1 = (x / 1000);

                sayac = sayac + 1;          //kullanıcı her sayı girdiğinde değeri artan bir sayaç sistemi
            }
            Console.WriteLine("");
            Console.WriteLine("Tebrikler tutulan " + rastgele +" sayısını "+sayac+" denemede buldunuz.");
            Console.WriteLine("");
            Console.WriteLine("Devam etmek istiyor musunuz Evet/E , Hayır/H"); //kullanıcıya devam hakkı verme/sorma
            string soru=Console.ReadLine(); //kullanıcı yanıtı

            if (soru=="e"||soru=="E") //cevabın değerlendirilmesi
            {
                goto tekrarla;
            }
            else
            {
                Console.WriteLine("Program sonlandırıldı");
            }
            #endregion
        }
    }
}
