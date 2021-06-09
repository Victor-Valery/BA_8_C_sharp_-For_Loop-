﻿using System;

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


            int x = 10;
            while (x > 5)
            {
                Console.WriteLine("Hallo");
                x++;
            }


            //  Örnek - 3: 1 ile 100 arasindaki tek ve cift sayilari bulan bir algoritma

            for (int i = 0; i < 100; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i +"Cifttir");
                }

                else
                {
                    Console.WriteLine(i + "Tektir");
                }


            }



            // Örnek - 4: kullanicidan sayi al. Alinan sayi kadar olan rakamlarin toplamini bul. 
            // Aciklama: 10 = 0+1+2+3+.............. = 99

            while (true)
            {

            int toplam = 0;

            Console.WriteLine("Lütfen bir tam sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            for (int i = 0; i <= sayi; i++)
            {
                toplam = toplam + i; // toplam +=i; seklinde de yazilabilir.
            }

            Console.WriteLine("TOPLAM = " + toplam);

            }


            //*****************

            int x = 3;
            string kullaniciAdi = "Admin";

            while (x>0)
            {
                Console.WriteLine("Kullanici adini giriniz");
                string ekranKullanici = Console.ReadLine();

                if (kullaniciAdi==ekranKullanici)
                {
                    Console.WriteLine("Hosgeldiniz");
                }
                else
                {
                    Console.WriteLine("Yanlis giris yapildi");
                    x--;
                    Console.WriteLine("Su anda" + x + "hakkiniz kaldi");
                }
            }
            Console.WriteLine("Hesanbiniz Kilitlendi");






        }
    }
}
