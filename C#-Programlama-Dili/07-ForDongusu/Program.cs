﻿namespace _07_ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 5; i < 15; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //sonsuz döngü oluşur
            //for (int i = 5; i > 0; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 20; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 20; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //for (char i = 'a'; i < 'z'; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i =0; i < 0; i++)
            //{

            //}

            //int sayi = 0;
            //int baslangic = 25;
            //for (sayi = baslangic + 1; sayi < 50; sayi++)
            //{
            //    if (sayi > baslangic)
            //        Console.WriteLine(sayi);

            //}




            //1 ile 50 arasındaki çift sayıları ekrana yazdıran kod bloğu
            //Console.WriteLine("Başlangıç değerini giriniz :");
            //int baslangic = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Bitiş değerini giriniz :");
            //int bitis = Convert.ToInt32(Console.ReadLine());

            //for (int i = baslangic; i <= bitis; i ++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}


            //if (baslangic % 2 != 0)
            //    baslangic++;

            //for (int i = baslangic; i <= bitis; i+=2)
            //{
            //    Console.WriteLine(i);
            //}





            //kullanıcıdan bir tane metin isteyelim
            //kaç sefer ekrana yazdırmak istiyorsun ?

            //Console.WriteLine("Bir metin giriniz:");
            //string metin = Console.ReadLine();

            //Console.WriteLine("Kaç sefer yazdırmak istiyorsunuz ?");
            //int sayi = int.Parse(Console.ReadLine());

            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.WriteLine(metin);
            //}


            //for (int sayi = 1; sayi < 15; sayi++) 
            //{ 
            //    for(char harf = 'A'; harf < 'K'; harf++)
            //    {
            //        Console.WriteLine($"Sayı={sayi}-Harf={harf}");
            //    }
            //}





            //1*1=1
            //1*2=2
            //..
            //2*1=2
            //2*2=4


            for (int carpilan = 1; carpilan <= 10; carpilan++)
            {
                for (int carpan = 1; carpan <= 10; carpan++)
                {
                    Console.WriteLine($"{carpilan}*{carpan}={carpilan * carpan}");
                }
            }
        }
    }
}
