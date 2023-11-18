namespace _03_TipDonusturmeMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Convert sınıfı ile tip değiştirme
            string sayi1 = "5";
            string sayi2 = "6";

            int toplam = Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2);


            Console.WriteLine($"Sonuç = {toplam}");
            Console.WriteLine($"Sonuç = {sayi1 + sayi2}");


            //int sonuc = Convert.ToInt32("78") - Convert.ToInt32("20");
            //int sonuc = Convert.ToInt32("78") - Convert.ToInt32(Convert.ToInt16(sayi1) + Convert.ToInt16(sayi2));
            char karakter = Convert.ToChar(sayi1);
            //char karakter = Convert.ToChar("5");



            int birinciSayi = 8;
            int ikinciSayi = 9;
            //double sonuc = birinciSayi) / ikinciSayi;  //int tipinde değerler olduğu için sonuç virgüllü olarakbize dönmez
            double sonuc = Convert.ToDouble(birinciSayi) / Convert.ToDouble(ikinciSayi);

            Console.WriteLine($"Sonuç = {sonuc}");


            int a = 0;
            int b = 1;
            bool c = Convert.ToBoolean(a);
            bool d = Convert.ToBoolean(b);
            #endregion


            #region Parse metodu ile tip değiştirme
            toplam = int.Parse(sayi1) + int.Parse(sayi2);
            Console.WriteLine("Sonuç = " + toplam);

            decimal virgulluSonuc = decimal.Parse(sayi1) / decimal.Parse(sayi2);
            Console.WriteLine("Sonuç = " + virgulluSonuc);


            //ArgumentNullException = değer null olduğu için hata fırlatır.
            //string? deger1 = null;
            //Convert.ToInt32(deger1);
            //int.Parse(deger1);


            //FormatException = değer uygun formatta olmadığı zaman bu hata fırlatılır.
            //Convert.ToInt32("5p");

            //OverflowException = değer dönüştürülecek hedef türün sınırları dışında ise bu hata fırlatılır
            //Convert.ToInt16(999999999);


            //Convert sınıfı ile Parse metodu arasındaki farklar
            //1.Fark
            //convert sınıfı ile belirli tipleri dönüşterebiliriz (int, decimal, datetime, double, bool, char, byte).
            //Ama parse metodun da tüm türleri dönüştürebiliriz.

            //2.Fark
            //Convert sınıfında değerin null olması durumunda ArgumentNullException hatasına düşmez, fakat parse metodunda hataya düşer 
            #endregion


            #region ToString metodu ile string tipine dönüştürme
            decimal x = 5;
            decimal y = 7;
            Console.WriteLine(x.ToString());
            Console.WriteLine(x.ToString() + y.ToString());

            decimal sonuc1 = x / y;
            Console.WriteLine(sonuc1);
            Console.WriteLine(sonuc1.ToString("n2"));
            Console.WriteLine(123143.ToString("c2"));
            #endregion


            #region Implicit(Üstü kapalı) ve Explicit(Belirgin) Dönüşümler

            //üstü kapalı
            int t = 135;
            long u = t;


            //belirgin
            long i = 123;
            int i2 = (int)i;

            #endregion



            //Console.WriteLine("Lütfen adınızı giriniz..");
            //string adi = Console.ReadLine();
            //Console.WriteLine("Adınız : " + adi);



            #region Örnek 1
            //Birinci Sayıyı giriniz...
            //İkinici sayıyı giriniz...
            //iki sayının toplamını ekrana yazdırsın. Toplam = 123 

            //Console.WriteLine("Birinci sayıyı giriniz :");
            //string birinciSayi1 = Console.ReadLine();
            //Console.WriteLine("İkinci sayıyı giriniz :");
            //string ikinciSayi2 = Console.ReadLine();

            //int toplam1 = int.Parse(birinciSayi1) + Convert.ToInt32(ikinciSayi2);
            //Console.WriteLine("Girdiğiniz sayıların toplamı = " + toplam1);


            //Console.WriteLine("Birinci sayıyı giriniz :");
            //int birinciSayi1_ = int.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz :");
            //birinciSayi1_ += int.Parse(Console.ReadLine());
            //Console.WriteLine("Girdiğiniz sayıların toplamı = " + birinciSayi1_);
            #endregion


            #region Örnek 2
            //Kullanıcıdan iki tane tam sayı formatında değer girmesini isteyelim.
            //Bu iki sayının ortalamasını hesaplayıp virgülden sonra 2 hane olacak şekilde ekrana yazdıralım.
            //birinci sayı =7, ikinci sayı = 4, 



            Console.WriteLine("1. Sınav Notunu Girin :");
            int not1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. Sınav Notunu Girin :");
            int not2 = Convert.ToInt32(Console.ReadLine());

            //double notOrtalamasi = (not1 + not2) / 2.0;
            double notOrtalamasi = (((double)not1) + ((double)not2)) / 2;
            //Console.WriteLine("Not Ortalaması : " + notOrtalamasi.ToString("n2"));
            Console.WriteLine("Not Ortalaması : " + notOrtalamasi.ToString(".##"));

            #endregion


            Console.ReadKey();
        }
    }
}
