namespace _14_MethodKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk satır");
            MethodIsmi();
            Console.WriteLine("Son Satır");

            Merhaba("Aykut");
            //Merhaba2(37);
            Yasiniz("Aykut", 38);
            Yasiniz(yas: 33, adiSoyadi: "Hasan");


            Yasiniz2();
            Yasiniz2("Aykut");
            Yasiniz2("Aykut", 38);

            Yasiniz3("Ahmet", null);


            int toplam = Topla(10, 30);
            Console.WriteLine("Toplam = " + toplam);
            Console.WriteLine("Toplam = " + Topla(25, 5));


            Console.WriteLine("İşlem Sonucu = " + IslemYap(40, 20, "topla"));


            Console.Clear();
            string result = "";
            if (OndanBuyukMu(9, out result) == true)
            {
                Console.WriteLine("Sayı 10'dan büyüktür");
            }
            else
            {
                Console.WriteLine("Sayı 10'dan küçüktür");
            }
            Console.WriteLine("-------------");
            Console.WriteLine(result);


            Console.Clear();

            int sayiDegeri = 0;
            if (SayiMi("123", out sayiDegeri))
                Console.WriteLine("Girilen değer sayıdır = " + sayiDegeri);
            else
                Console.WriteLine("Girilen değer sayı değildir.");
        }



        //static keyword (anahtar sözcüğü) = erişim belirleyici
        //Geriye değer döndürmeyen, parametre almayan sadece kod bloğu içindeki satırları çalıştıran method.
        static void MethodIsmi()
        {
            //kod bloğu iki süslü parantez arası
            Console.WriteLine("Hello, World!");
        }


        //geriye değer döndürmeyen, tek paramatre alan method
        static void Merhaba(string adiSoyadi)
        {
            Console.WriteLine("Marhaba " + adiSoyadi);
            Merhaba2(36);
        }

        static void Merhaba2(int yas)
        {
            Console.WriteLine(yas);
        }


        //geriye değer döndürmeyen, iki parametre alan method
        static void Yasiniz(string adiSoyadi, int yas)
        {
            Console.WriteLine(adiSoyadi + " " + yas + " yaşındadır.");
        }


        //geriye değer döndürmeyen, default değerlere sahip parametre tanımı olan method
        static void Yasiniz2(string adiSoyadi = "ahmet", int yas = 18)
        {
            Console.WriteLine(adiSoyadi + " " + yas + " yaşındadır.");
        }


        //geriye değer döndürmeyen , nullable parametre barındıran method
        static void Yasiniz3(string adiSoyadi, int? yas)
        {
            Console.WriteLine(adiSoyadi + " " + yas + " yaşındadır.");
        }



        //geriye int tipinde değer döndüren ve iki tane parametre alan method
        static int Topla(int sayi1, int sayi2)
        {

            //int sonuc = sayi1 + sayi2;

            //return sonuc;
            return sayi1 + sayi2;
        }


        static double IslemYap(double sayi1, double sayi2, string islemTipi)
        {
            //if (islemTipi == "topla")
            //{
            //    return sayi1 + sayi2;
            //}
            //else if (islemTipi == "cikar")
            //{
            //    return sayi1 - sayi2;
            //}
            //else
            //    return sayi1 * sayi2;

            double sonuc = 0;
            if (islemTipi == "topla")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (islemTipi == "cikar")
            {
                sonuc = sayi1 - sayi2;
            }

            return sonuc;
        }



        //out keyword'ü kullanarak parametre tanımlanan, geriye bool değer döndüren method
        static bool OndanBuyukMu(int sayi, out string sonuc)
        {
            if (sayi > 10)
            {
                sonuc = "Sayı 10'dan büyüktür";
                return true;
            }
            else
            {
                sonuc = "Sayı 10'dan küçüktür";
                return false;
            }
        }



        //Method Overload
        //aynı isimde birden fazla method tanımlamak için, mutlaka parametrelerinin sayısı, tipi, nullable olup olmadığı gibi parametrelerinin farklı olması gerekir.
        //aynı isimde birden fazla method yazıabilmesine method overload denir.
        //aynı isimdeki methodların mutalaka imzaları (signature) farklı olmalıdır.
        //imza(signature) = metodun parametreleridir. Methodun geriye dönüş tipi imzasına dahil değildir.
        static int Topla(int sayi1)
        {

            return 0;
        }
        static int Topla(int sayi1, int sayi2, int sayi3)
        {

            return 0;
        }
        static int Topla(decimal sayi1)
        {
            return 0;
        }
        static int Topla(decimal? sayi1)
        {
            return 0;
        }



        //SayiMi metodunu yazılması. int.TryParse metodun yerine kullanmak üzere yapılıyor.
        //Metohd string bir değerin sayı olup olmadığını kontrol edecek, 
        //Sayı ise geriye true değer döndürecek ve aynı zamanda dönüştürdüğü sayıyı dışarı atacak.
        //sayı değil ise geriye false değer döndürecek ve dışarıya sıfır değerini atacak.

        static bool SayiMi(string deger, out int donusturulenSayi)
        {
            try
            {
               donusturulenSayi = Convert.ToInt32(deger);

                return true;
            }
            catch (Exception ex)
            {
                donusturulenSayi = 0;
                return false;
            }
        }
    }
}