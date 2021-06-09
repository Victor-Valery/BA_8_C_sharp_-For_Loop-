using System;

namespace BA_C_SHARP_8__For_Loop_
{
    class Program
    {
        static void Main(string[] args)
        {
            // For Loop
            // Örnek - 1:  Ekarana 10 kere Hallo yazmak
            // Baslangic - bitis - artis miktari (Döngünü artis miktari)

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hallo_" + i);
            }

            // Örnek - 2: 1'den 100'e kadar cift sayilari bulup ekrana yazdiran algoritmayi tasarlayin.

            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // 1 ile 1250 arasinda 7'ye tam bölünebilen X kadar sayi vardir.

            int basket = 0;

            for (int i = 1; i < 1250; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                    basket = basket + 1;
                }
            }

            Console.WriteLine("********************");
            Console.WriteLine($"1 ile 1250 arasinda 7'ye tam bölünebilen {basket}  tane sayi vardir.");

        }
    }
}
