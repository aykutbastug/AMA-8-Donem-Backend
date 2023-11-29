namespace _09_Ornek_HesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim = -1;

            do
            {
                Console.Clear();
                Console.WriteLine("Hesap Makinesi Uygulaması");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Menü");
                Console.WriteLine("1 - Toplama İşlemi Yap");
                Console.WriteLine("2 - Çıkarma İşlemi Yap");
                Console.WriteLine("3 - Çarpma İşlemi Yap");
                Console.WriteLine("4 - Bölme İşlemi Yap");
                Console.WriteLine("0 - Uygulamayı Kapat");
                Console.WriteLine("");
                Console.WriteLine("Hangi işlemi yapmak istiyorsunuz ?");


                try
                {
                    secim = int.Parse(Console.ReadLine());

                    switch (secim)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Toplama İşlemi");
                            Console.Write("--------------");
                            Console.WriteLine("");
                            Console.WriteLine("");

                            Console.WriteLine("Lütfen 1. Sayıyı Giriniz : ");
                            int sayi1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Lütfen 2. Sayıyı Giriniz : ");
                            int sayi2 = int.Parse(Console.ReadLine());

                            int sonuc = sayi1 + sayi2;
                            Console.WriteLine("İşlem Sonucu = " + sonuc);

                            Console.WriteLine("");
                            Console.WriteLine("Lütfen devam etmek için bir tuşa basın..");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Çıkarma İşlemi");
                            Console.Write("--------------");
                            Console.WriteLine("");
                            Console.WriteLine("");

                            Console.WriteLine("Lütfen 1. Sayıyı Giriniz : ");
                            sayi1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Lütfen 2. Sayıyı Giriniz : ");
                            sayi2 = int.Parse(Console.ReadLine());

                            sonuc = sayi1 - sayi2;
                            Console.WriteLine("İşlem Sonucu = " + sonuc);

                            Console.WriteLine("");
                            Console.WriteLine("Lütfen devam etmek için bir tuşa basın..");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Çarpma İşlemi");
                            Console.Write("--------------");
                            Console.WriteLine("");
                            Console.WriteLine("");

                            Console.WriteLine("Lütfen 1. Sayıyı Giriniz : ");
                            sayi1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Lütfen 2. Sayıyı Giriniz : ");
                            sayi2 = int.Parse(Console.ReadLine());

                            sonuc = sayi1 * sayi2;
                            Console.WriteLine("İşlem Sonucu = " + sonuc);

                            Console.WriteLine("");
                            Console.WriteLine("Lütfen devam etmek için bir tuşa basın..");
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Bölme İşlemi");
                            Console.Write("--------------");
                            Console.WriteLine("");
                            Console.WriteLine("");

                            Console.WriteLine("Lütfen 1. Sayıyı Giriniz : ");
                            sayi1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Lütfen 2. Sayıyı Giriniz : ");
                            sayi2 = int.Parse(Console.ReadLine());

                            sonuc = sayi1 / sayi2;
                            Console.WriteLine("İşlem Sonucu = " + sonuc);

                            Console.WriteLine("");
                            Console.WriteLine("Lütfen devam etmek için bir tuşa basın..");
                            Console.ReadKey();
                            break;

                    }
                }
                catch {; }

            } while (secim != 0);
        }
    }
}
