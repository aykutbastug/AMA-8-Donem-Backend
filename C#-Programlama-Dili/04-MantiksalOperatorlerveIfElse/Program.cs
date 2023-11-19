namespace _04_MantiksalOperatorlerveIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kullanıcı adınızı giriniz :");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifrenizi girin :");
            string sifre = Console.ReadLine();

            //if (kullaniciAdi == "aykut")
            //{
            //    Console.WriteLine("Kullanıcı adı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı hatalı");
            //}



            /*--> else bağlacının uzun kullanımı*/
            //if (kullaniciAdi == "aykut")
            //{
            //    Console.WriteLine("Kullanıcı adı doğru");
            //}
            // if (kullaniciAdi != "aykut")
            //{
            //    Console.WriteLine("Kullanıcı adı hatalı");
            //}




            //Eğer şartın içinde olan yorum satırı içinde tek satır varsa süslü parantez kullanmadan yazabiliriz; 
            //1'den fazla varsa süslü parantez kullanmak zorundayız'

            //if (kullaniciAdi == "aykut")
            //    Console.WriteLine("Kullanıcı adı doğru");
            //else
            //    Console.WriteLine("Kullanıcı adı hatalı"); 

            //diğer örnek;

            //if (sifre == "123")
            //    Console.WriteLine("Şifre doğru");
            //else
            //    Console.WriteLine("Şifre hatalı");


            //if içinde if kullanımı: ilk şarta bakıyor kullanıcı adı doğruysa şifre yi kontrol ediyor değilse kullanıcı adı hatalı olarak yazdırıyor ve direkt çıkış veriyor (şifrenin doğruluğunu ya da yanlış olmasını yazdırmıyor);

            //if (kullaniciAdi == "aykut")
            //{
            //    Console.WriteLine("Kullanıcı adı doğru");

            //    if (sifre == "123")
            //        Console.WriteLine("Şifre doğru");
            //    else
            //        Console.WriteLine("Şifre hatalı");
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı hatalı");
            //}


            //&& --> ilk şart sağlanıyorsa ikinci şarta bakar; ilk şart sağlanmıyorsa ikinci şarta bakmaz
            //& (c# da bu kullanım kalktı) --> ilk şart bakıyor sağlanıyor veya sağlanmıyor önemli değil ikinci şarta da bakıyor(yani ikiside sağlanıyor mu diye kontrol ediyor) : örn; 

            //if (kullaniciAdi == "aykut" && sifre == "123")
            //    Console.WriteLine("Giriş başarılı");
            //else
            //    Console.WriteLine("Kullanıcı adı veya şifresi hatalı");


            //|| --> veya kullanımı:

            if (kullaniciAdi != "aykut" || sifre != "123")
                Console.WriteLine("Kullanıcı adı veya şifresi hatalı");
            else
                Console.WriteLine("Giriş yaptınız");

            //veya kullanımına başka bir örnek;

            Console.WriteLine("Devam etmek istiyor musunuz ? (E/H)");
            string degisken1 = Console.ReadLine();

            if (degisken1 == "E" || degisken1 == "e")
                Console.WriteLine("Evet");
            else if (degisken1 == "H" || degisken1 == "h")
                Console.WriteLine("Hayır");
            else
                Console.WriteLine("Hatalı seçim yaptınız");
            Console.ReadKey();

            //operatörler:
            // ==
            // !=
            // >
            // <
            // >=
            // <=
            // % 2 --Mod alma

            //if else örnek:

            //int sayi1 = 10;
            //int sayi2 = 20;

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Sayı1 büyüktür");
            //}
            //else if (sayi1 == sayi2)
            //{
            //    Console.WriteLine("Sayılar eşit");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı2 büyüktür");
            //}

            //yukarıdaki kodun kısa yazımı: 

            //if (sayi1 > sayi2 && sayi1 > 0)
            //    Console.WriteLine("Sayı1 büyüktür");
            //else if (sayi1 == sayi2)
            //    Console.WriteLine("Sayılar eşit");
            //else
            //    Console.WriteLine("Sayı2 büyüktür");



            //kullanıcnın bir sayı girmesini isteyelim
            //negatif bir sayı girdi ise uyarı verip uygulamayı bitirelim
            //pozitif sayı girdi ise, ikinci sayıyı girmesini isteyim
            //ikinci sayınında negatif bir sayı girdi ise uyarı verip uygulamayı bitirelim
            //pozitif sayı girdi ise iki sayının çarpımını ekrana yazdıran kod bloğu


            //1.yöntem:

            //Console.WriteLine("Birinci sayıyı giriniz..");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            ////if (sayi1 < 0 || sayi1 == 0)
            //if (sayi1 <= 0)
            //{
            //    Console.WriteLine("Negatif bir sayı girdiniz..");
            //}
            //else
            //{
            //    Console.WriteLine("İkinci sayıyı giriniz..");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    if (sayi2 <= 0)
            //    {
            //        Console.WriteLine("Negatif bir sayı girdiniz..");
            //    }
            //    else
            //    {
            //        Console.WriteLine("İki sayının çarpımı = " + (sayi1 * sayi2));
            //    }
            //}

            //2.yöntem:

            //if (sayi1 > 0)
            //{
            //    Console.WriteLine("İkinci sayıyı giriniz..");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    if (sayi2 > 0)
            //    {
            //        Console.WriteLine("İki sayının çarpımı = " + (sayi1 * sayi2));                    
            //    }
            //    else
            //        Console.WriteLine("Negatif bir sayı girdiniz..");
            //}
            //else
            //    Console.WriteLine("Negatif bir sayı girdiniz..");

            //Soru2: çift sayıları yazdırcak
            //if (sayi1 % 2 == 0)
            //4-3-7-8
            //4,8 

            //benim çözümüm:

            Console.WriteLine("birinci sayıyı giriniz..");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayıyı giriniz..");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("üçüncü sayıyı giriniz..");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dördüncü sayıyı giriniz..");
            int sayi4 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 % 2 == 0) ;
            Console.Write($"{sayi1}");
            if (sayi2 % 2 == 0) ;
            Console.Write($"{sayi2}");
            if (sayi3 % 2 == 0) ;
            Console.Write($"{sayi3}");
            if (sayi4 % 2 == 0) ;
            Console.Write($"{sayi4}");

            //(burada else kullanamayız çünkü bütün hepsine tek tek bakmamız gerekiyor) yukarıdaki örnek için

            //1.yöntem:

            //Console.WriteLine("Birinci sayıyı giriniz..");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("İkinci sayıyı giriniz..");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Üçüncü sayıyı giriniz..");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Dördüncü sayıyı giriniz..");
            //int sayi4 = Convert.ToInt32(Console.ReadLine());


            //string sonuc = "";
            //if (sayi1 % 2 == 0)
            //    sonuc += sayi1 + ", ";

            //if (sayi2 % 2 == 0)
            //    sonuc += sayi2 + ", ";

            //if (sayi3 % 2 == 0)
            //    sonuc += sayi3 + ", ";

            //if (sayi4 % 2 == 0)
            //    sonuc += sayi4 + ", ";

            //Console.WriteLine(sonuc);

            //2.yöntem:

            //if (sayi1 % 2 == 0)
            //    Console.Write(sayi1 + ", ");

            //if (sayi2 % 2 == 0)
            //    Console.Write(sayi2 + ", ");

            //if (sayi3 % 2 == 0)
            //    Console.Write(sayi3 + ", ");

            //if (sayi4 % 2 == 0)
            //    Console.Write(sayi4 + ", ");


            //Boolean değerin if ile kullanımı:

            //bool evliMi = false;
            //if (evliMi == true)
            //{
            //    Console.WriteLine("Evli");
            //}

            //if (evliMi == false)
            //{
            //    Console.WriteLine("Evli Değil");
            //}

            //if (evliMi != true)
            //{
            //    Console.WriteLine("Evli Değil");
            //}

            //if (evliMi != false)
            //{
            //    Console.WriteLine("Evli");
            //}

            ////if (evliMi == true) --> aşağıdaki kodla aynı anlama geliyor
            //if (evliMi)
            //{
            //    Console.WriteLine("Evli");
            //}

            ////if (evliMi == false)
            //if (!evliMi)
            //{
            //    Console.WriteLine("Evli Değil");
            //}


            //ternary operator
            //string sonuc = evliMi ? "Evli" : "Evli Değil";
            //Console.WriteLine(sonuc);

            //Console.WriteLine(evliMi ? "Evli" : "Evli Değil"); --> bu kodun if ile uzun yazılmış hali aşagıda:

            //if (evliMi == true)
            //    Console.WriteLine("Evli");
            //else
            //    Console.WriteLine("Evli Değil");

            //ternary operator baska örnek:

            //int sayi1 = 40;
            //Console.WriteLine(sayi1 <= 0 ? "Negatif Sayı" : "Pozitif Sayı");

            //ternary operator baska örnek:

            int kenarUzunlugu = 4;
            string alan = kenarUzunlugu <= 0 ? "Hatalı değer girdiniz" : (kenarUzunlugu * kenarUzunlugu).ToString();
            Console.WriteLine();  /*(şartın biri stringse ("Hatalı değer girdiniz") diğer şart da ((kenarUzunlugu* kenarUzunlugu)) string olmali)*/
        }
    }
}
