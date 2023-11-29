namespace _12_ForeachDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] takimlar = { "Beşiktaş", "Fenerbahçe", "Galatasaray", "Trabzonspor" };

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(takimlar[i]);
            //}

            //foreach (string takim in takimlar)
            //foreach (var takim in takimlar)
            //{
            //    Console.WriteLine(takim);
            //}



            //ÖRNEK
            //Meyveler dizimiz olsun, elaman sayısını kullanıcı belirlesin.
            //Sayıyı belirledikten sonra her bir elemanın değerlerini tek tek doldursun.
            //Son olarak elemanın tüm değerlerini ekrana alt alta yazdıran kod bloğu.


            //Console.WriteLine("Kaç tane meyve girmek istiyorsunuz ?");
            //string[] meyveler = new string[Convert.ToInt32(Console.ReadLine())];

            //for (int i = 0; i < meyveler.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. Meyve'yi Giriniz :");
            //    meyveler[i] = Console.ReadLine();
            //}

            //Console.Clear();
            //Console.WriteLine("Girdiğiniz Meyveler:");

            //int index = 1;
            //foreach (var meyve in meyveler)
            //{
            //    Console.WriteLine($"{index}. Meyve = {meyve}");
            //    index++;
            //}




            //sayilar dizimiz olsun, eleman sayısını kullanıcı belirlesin. hatalı bir değer girdiğinde uygulama hata vermesin tekrar değer girmesini istesin.
            //girdiği sayıları toplayarak, sonucu ekrana yazdırsın.


            Console.WriteLine("Dizinin eleman sayısını girin :");
            
            int elamanSayisi = 0;
            //while(int.TryParse(Console.ReadLine(), out elamanSayisi) != true)
            //while(int.TryParse(Console.ReadLine(), out elamanSayisi) == false)
            while (!int.TryParse(Console.ReadLine(), out elamanSayisi) || elamanSayisi < 1)
            {
                Console.Clear();
                Console.WriteLine("Hatalı bir değer girdiniz..");
                Console.WriteLine("Dizinin eleman sayısını tekrar girin :");
            }

            int[] sayilar = new int[elamanSayisi];

            for (int i = 0; i < elamanSayisi; i++)
            {
                Console.WriteLine($"{i + 1}. Sayıyı Girin :");
                while (!int.TryParse(Console.ReadLine(), out sayilar[i]) || sayilar[i] < 1)
                {
                    Console.Clear();

                    if (sayilar[i] < 0)
                    {
                        Console.WriteLine("Pozitif bir değer girmediniz..");
                        Console.WriteLine($"{i + 1}. Sayıyı Tekrar Girin :");
                    }
                    else
                    {
                        Console.WriteLine("Hatalı bir değer girdiniz..");
                        Console.WriteLine($"{i + 1}. Sayıyı Tekrar Girin :");
                    }                    
                }
            }

            int sonuc = 0;
            foreach (var eleman in sayilar)
            {
                sonuc += eleman;
            }
            Console.WriteLine("Girilen sayıların toplamı = " + sonuc);
        }
    }
}
