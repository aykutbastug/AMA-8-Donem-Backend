using System.Dynamic;

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

            //!!Convert işlemi sadece ilgili değişkenin içindeki değeri convert ediyor. 
            // Yani "string sayi1=5" hala string değerindeyken; sadece sayi1'in "int toplam = Convert.ToInt32(sayi1)" içerisindeki değerini convert ediyoruz. 

            Console.WriteLine($"Sonuç = {toplam}");
            Console.WriteLine($"Sonuç = {sayi1 + sayi2}");

            ------------------------------
            //!!İllaki yukarıda yaptığımız gibi Convert.ToInt32() metodunun içine doğrudan bir değişken vermek zorunda değiliz -sayi1- gibi, direkt değer de verebilri mesela;

            int sonuc = Convert.ToInt32("78") - Convert.ToInt32("20");

            ------------------------------

            //!! iç içe convert işlemi de yapılabilir mesela;

            int sonuc = Convert.ToInt32("78") - Convert.ToInt32(Convert.ToInt16(sayi1) + Convert.ToInt16(sayi2));

            ----------------------------

            char karakter = Convert.ToChar(sayi1);
            char karakter = Convert.ToChar("5");

            ---------------------------

            int birinciSayi = 8;
            int ikinciSayi = 9;
            double sonuc = birinciSayi / ikinciSayi; /*--> int tipinde değerler olduğu için sonuç virgüllü olarak bize dönmez*/

            //Eğer virgüllü olarak almak istiyorsam bu işlemi "- double sonuc = birinciSayi / ikinciSayi-"  convert etmem gerek;

            double sonuc = Convert.ToDouble(birinciSayi) / Convert.ToDouble(ikinciSayi);
            Console.WriteLine($"Sonuç = {sonuc}");

            --------------------

            //boolen tipinde dönüşüm örneği;

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

            --------------------

            //Dönüştürme işlemlerinde 3 tane hat alma ihtimalimiz var:

            //ArgumentNullException = değer null olduğu için hata fırlatır.

            string ? deger1 = null:
            Convert.ToInt32(deger1);    /*-->Convert sınıfında değer null olduğu için ArgumentNullException hatasına düşmedi*/
            int.Parse(deger1);    /*--> Ama Parse metodunda değer null olduğu için ArgumentNullException hatasına düştü.(Yani null gelme ihtimali varsa parse değil convert kullan)*/


            //FormatException = değer uygun formatta olmadığı zaman bu hata fırlatılır.
            Convert.ToInt32("5p");     /* -->int e dönüştüremedi çünkü "5p" uygun formatta değil. "5p" nin int e dönüşebilmesi için numeric olması gerek yani "p"nin olmaması gerek.*/


            //OverflowException = değer dönüştürülecek hedef türün sınırları dışında ise bu hata fırlatılır
            Convert.ToInt16(999999999);    /* --> "999999999" böyle bir değer short tipine convert edilemez. Çünkü long tipinde bir değer ve short tipine convert edilemez.*/

            ---------------------------

            //Convert sınıfı ile Parse metodu arasındaki farklar:

            //1.Fark
            //convert sınıfı ile belirli tipleri dönüşterebiliriz (int, decimal, datetime, double, bool, char, byte).
            //Ama parse metodun da tüm türleri dönüştürebiliriz.
            //Parse ın bir avantajı da "TryParse" ile elimizdeki değişkenin dönüştürülebilir olup olmadığını söylüyor.

            //2.Fark
            //Convert sınıfında değerin null olması durumunda ArgumentNullException hatasına düşmez, fakat parse metodunda hataya düşer 
            #endregion


            #region ToString metodu ile string tipine dönüştürme !!sadece stringe özel

            int x = 5;
            int y = 10;
            Console.WriteLine(x.ToString() + y.ToString()); /*-->yazdırdığında 510 olarak yanyana yazdırıyor çünkü string tipinde dönüşüm yapıp topladık*/


            //decimal x = 5;
            //decimal y = 7;
            //Console.WriteLine(x.ToString());
            //Console.WriteLine(x.ToString() + y.ToString());

            //decimal sonuc1 = x / y;
            //Console.WriteLine(sonuc1.ToString("n2")); /*--> n'nin anlamı numeric, "n2" diyerek yani sayı tipinde ama virgülden sonra 2 haneli olarak kullan anlamına gelir.*/
            //Console.WriteLine(123143.ToString("c2")); /*-->/**/ c ise currency yani para birimi anlamına geliyor.*/

            #endregion


            #region Implicit(Üstü kapalı) ve Explicit(Belirgin) Dönüşümler

            //üstü kapalı boxing
            //int t = 135;
            //long u = t;


            //belirgin  unboxing
            //long i = 123;
            //int i2 = (int)i;

            #endregion



            //Console.WriteLine("Lütfen adınızı giriniz..");
            //string adi = Console.ReadLine();
            //Console.WriteLine("Adınız : " + adi);



            #region Örnek 1
            //Birinci Sayıyı giriniz...
            //İkinici sayıyı giriniz...
            //iki sayının toplamını ekrana yazdırsın. Toplam = 123 

            //Benim çözümüm

            //Console.WriteLine(birinci sayıyı giriniz..);
            //int sayi1 = Convert.ToInt32(Console.ReadLine());   --> /*Console.ReadLine string? tipinde dönüyor dolayısıyla bizde değişkenimizi (sayi1) int tipinde tanımladığımız için Console.ReadLine ı int tipine convert etmemiz gerekiyor (ya da direkt string olarak girebiliriz değişkenin tipini tercihe kalmış*/
            //Console.WriteLine(ikinci sayiyi giriniz..);
            //int sayi2 = Convert.ToInt32(Console.ReadLine()) ;

            //Console.WriteLine("sonuc=" sayi1 + sayi2);


            //Hocanın çözümü 1
            //Console.WriteLine("Birinci sayıyı giriniz :");
            //string birinciSayi1 = Console.ReadLine();
            //Console.WriteLine("İkinci sayıyı giriniz :");
            //string ikinciSayi2 = Console.ReadLine();

            //int toplam1 = int.Parse(birinciSayi1) + Convert.ToInt32(ikinciSayi2);
            //Console.WriteLine("Girdiğiniz sayıların toplamı = " + toplam1);

            //Hocanın çözümü 2

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

            //benim çözümüm

            //Console.WriteLine(birinci tam sayiyi giriniz..);
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(ikinci sayiyi giriniz..);
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("sonuc="(sayi1 + sayi2) / 2);

            //Hocanın çözümü 1

            //Console.WriteLine("1. Sınav Notunu Girin :");
            //int not1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2. Sınav Notunu Girin :");
            //int not2 = Convert.ToInt32(Console.ReadLine()); 

            //double notOrtalamasi = (not1 + not2) / 2.0;
            //double notOrtalamasi = (((double)not1) + ((double)not2)) / 2;
            //Console.WriteLine("Not Ortalaması : " + notOrtalamasi.ToString("n2"));
            //Console.WriteLine("Not Ortalaması : " + notOrtalamasi.ToString(".##"));

            #endregion


            Console.ReadKey();
        }
    }
}
