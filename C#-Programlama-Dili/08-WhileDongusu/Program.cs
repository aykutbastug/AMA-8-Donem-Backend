namespace _08_WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //şart sağlandığı müddetçe döngü çalışır
            //int i = 5;
            //while (i <10)
            //{
            //    //çalıştırmak istediğimiz kod bloglarını buraya yazıyoruz

            //    //artırma veya azaltma işlemi manüel yapılır
            //    i++;
            //}


            //!!! - SONSUZ DÖNGÜ 1
            //while (true)
            //{

            //}


            //!!! - SONSUZ DÖNGÜ 2
            //while (i == 0)
            //{

            //}


            //!!! - SONSUZ DÖNGÜ 3
            //while (i > 4)
            //{

            //}


            //bu kullanımda 1 ve 10 dahil sayıları ekrana yazar
            //int sayi = 0;
            //while (sayi < 10)
            //{
            //    sayi++;
            //    Console.WriteLine(sayi);
            //}


            //bu kullanımda 0 ve 9 dahil olmak üzere sayıları ekrana yazdırır
            //int sayi = 0;
            //while (sayi < 10)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}


            //9 dan 0 a kadar sayıları yanyana yazdıran kod bloğunu yazınız
            //9876543210

            int i = 9;
            while (i >= 0)
            {
                Console.Write(i);
                i--;
            }

            //for (int a = 0; a < 6; a++)
            //    Console.WriteLine(a);

            //while (i >= 0)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

        }
    }
}
