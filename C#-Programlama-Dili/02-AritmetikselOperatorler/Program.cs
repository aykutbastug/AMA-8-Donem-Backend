using System;

namespace _02_AritmetikselOperatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region (+) Operatörü
            //Sayısal değerlerde toplama işlemi yapmak için kullanılır
            //Metinsel değerleri birleştirmek için kullanılır

            int toplam = 5 + 10 + (8 + 4);
            Console.WriteLine("Sonuç =" + toplam);


            decimal fiyat1 = 125.53M;
            decimal fiyat2 = 25.21M;

            decimal toplamFiyat = fiyat1 + fiyat2;
            Console.WriteLine("Toplam Ücret = " + toplamFiyat + " TL");
            Console.WriteLine("Toplam Ücret = " + (fiyat1 + fiyat2) + " TL");

            Console.WriteLine("Toplam Ücret = " + fiyat1 + fiyat2 + " TL");
            Console.WriteLine(fiyat1 + fiyat2 + " TL");
            Console.WriteLine(" " + fiyat1 + fiyat2);
            Console.WriteLine(fiyat1 + fiyat2);
            Console.WriteLine(fiyat1 + fiyat2 + 10);

            string adi = "Aykut";
            string soyadi = " BAŞTUĞ";
            Console.WriteLine(adi + soyadi);

            //+ operatörü kullanılmadan metinsel değerlerin birleştirilmesi
            Console.WriteLine($"Toplam Ücret = {toplamFiyat} TL");
            #endregion

            Console.WriteLine("==========================");

            #region (-) Operatörü
            //Sayısal değerlerde çıkarma işlemi yapmak için kullanılır, Metinsel değerlerde kullanılmaz.

            int sayi1 = 24;
            int sayi2 = 14;
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("Sonuç = " + sonuc);
            Console.WriteLine("Sonuç = " + (sayi2 - sayi1));
            Console.WriteLine(((sayi2 - sayi1) + (50 + 20)) + " Sonuç");
            #endregion

            Console.WriteLine("==========================");

            #region (*) Operatörü
            //Sayısal değerler arasında çarpma işlemi yapmak için kullanılır, Metinsel değerlerde kullanılmaz.

            sayi1 = 24;
            sayi2 = 14;
            sonuc = sayi1 * sayi2;
            Console.WriteLine("Sonuç = " + sonuc);
            Console.WriteLine("Sonuç = " + (sayi2 * sayi1));
            Console.WriteLine(((sayi2 * sayi1) + (50 + 20)) + " Sonuç");

            //+ operatörü kullanılmadan metinsel değerlerin birleştirilmesi
            Console.WriteLine($"Toplam Ücret = {sayi1 * sayi2} TL Sayıların Farkı = {sayi1 - sayi2} Sayıların Toplamı = {sayi1 + sayi2}");
            #endregion

            Console.WriteLine("==========================");

            #region (/) Operatörü
            //Sayısal değerler arasında bölme işlemi yapmak için kullanılır, Metinsel değerlerde kullanılmaz.

            sayi1 = 5;
            sayi2 = 3;
            sonuc = sayi1 / sayi2;
            Console.WriteLine("Sonuç = " + sonuc);


            decimal uzunluk1 = 5;
            decimal uzunluk2 = 3;
            Console.WriteLine("Sonuç = " + (uzunluk1 / uzunluk2));
            #endregion

            Console.WriteLine("==========================");

            #region (%) Operatörü
            //Sayısal değerler arasında mod alma işlemi yapmak için kullanılır, Metinsel değerlerde kullanılmaz.
            //iki sayının bölümünden kalan değeri

            sayi1 = 5;
            sayi2 = 3;
            Console.WriteLine("Sonuç = " + (sayi1 % sayi2));
            #endregion

            Console.WriteLine("==========================");

            #region ikili operatör kullanımı
            int yas = 35;
            yas++;
            yas++;

            yas--;
            Console.WriteLine("Sonuç = " + yas);


            int sayi5 = 65;
            --sayi5;
            ++sayi5;
            Console.WriteLine("Sonuç = " + sayi5);


            int sayi6 = 36;
            sayi6 += 10; //sayi6 = sayi6 + 10;
            Console.WriteLine("Sonuç = " + sayi6);

            sayi6 -= 10; //sayi6 = sayi6 - 10;
            Console.WriteLine("Sonuç = " + sayi6);

            sayi6 *= 10; //sayi6 = sayi6 * 10;
            Console.WriteLine("Sonuç = " + sayi6);

            sayi6 /= 10; //sayi6 = sayi6 / 10;
            Console.WriteLine("Sonuç = " + sayi6);
            #endregion


            bool evlimi = true;
            Console.WriteLine("Evli Mi = " + evlimi);
            Console.WriteLine("Evli Mi = " + !evlimi); /*!--> sadece boolen da tersine çevirme işlemi yapıyor yanı true ise false, false ise true.*/

            //Herhangi bir tuşa basılana dek console ekranı açık kalması için aşağıdaki kod satırı kullanılır
            Console.ReadKey();


            // Ödev1: Bir bakkalın veresiye defterine tutan bir uygulama yaptığımızı hayal edelim. Bu bağlamda lazım olacak olan değişkenleri tipleriyle birlikte yazınız.
            //  Müşteri Bilgileri = Adı Soyadı, Telefon, Adres, Toplam Borç, Toplam Alacak
            //  Ürün Bilgileri = Ürün Adı, Ürün Kodu, Birim Fiyatı, Stok Miktarı, Ölçü Birim(Adet, Kg, Gr vs)
            //  Müşteri Hareketleri = İşlem Tarihi, Ürün Adı, Birim Fiyatı, Miktarı, Tutarı, Kalan Alacak Tutarı


            string customernamesurname = "ceydabaskural";
            int phonenumber = 0551121654;
            string address = "İzmir";
            decimal totaldebt = 1000m;
            decimal totalreceive = 1500m;

            string productname;
            productname = "dress";
            long productcode = 256487613268;
            int unitprice;
            unitprice = 1000;
            long stockamount = 2000;
            string unitofmeasurement = "pcs";


            DateTime date= new DateTime (2023,11,15);
            productname = "dress";
            unitprice = 1000;
            long? unitamount = 5;
            unitprice = 1000;
            int remainamount = 0;


            Console.WriteLine(customernamesurname);
            Console.WriteLine(phonenumber);
            Console.WriteLine(address);
            Console.WriteLine(totaldebt);
            Console.WriteLine(totalreceive);
            Console.WriteLine(productname);
            Console.WriteLine(productcode);
            Console.WriteLine(unitprice);
            Console.WriteLine(stockamount);
            Console.WriteLine(unitofmeasurement);
            Console.WriteLine(date);
            Console.WriteLine(productname);
            Console.WriteLine(unitprice);
            Console.WriteLine(unitamount);
            Console.WriteLine(remainamount);

          




            //Ödev 2 : Bir okul uygulaması yaptığımızı hayal edelim. Bu bağlamda lazım olacak olan değişkenleri tipleriyle birlikte yazınız.

            //  Öğrenci Bilgileri = Adı Soyadı, Kayıt Tarihi, Sınıfı, Not Ortalaması
            //  Veli Bilgileri = Adi Soyadı, Telefon, Ev Adresi, İş Adresi, Annesi Mi ?
            //  Ders Bilgileri = Ders Adı, Sayısal Mı ?
            //  Ders Notları = Öğrenci Adı, Ders Adı, 1.Sınav Notu, 2.Sınav Notu, Not Ortalaması




        }
    }
}