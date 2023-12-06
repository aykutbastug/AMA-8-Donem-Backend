namespace DateTimeMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ToString()
            string tarih1 = DateTime.Today.ToString(); //saatsiz olarak
            string tarih2 = DateTime.Now.ToString(); //saatli olarak

            Console.WriteLine("saatsiz : " + tarih1);
            Console.WriteLine("saatli : " + tarih2);


            Console.Clear();
            string tarih3 = DateTime.Today.ToString("yyyy.MM.dd");
            string tarih4 = DateTime.Today.ToString("yyyyMMdd");

            Console.WriteLine("format 1 : " + tarih3);
            Console.WriteLine("format 2 : " + tarih4);




            //ShortString ve LongString
            Console.Clear();
            string kisaTarih = DateTime.Today.ToShortDateString();
            string uzunTarih = DateTime.Today.ToLongDateString();

            Console.WriteLine("Kısa Tarih : " + kisaTarih);
            Console.WriteLine("Uzun Tarih : " + uzunTarih);


            string kisaSaat = DateTime.Now.ToShortTimeString();
            string uzunSaat = DateTime.Now.ToLongTimeString();
            Console.WriteLine("Kısa Saat : " + kisaSaat);
            Console.WriteLine("Uzun Saat : " + uzunSaat);



            Console.Clear();
            //Add metotları
            DateTime bugun = DateTime.Now;

            Console.WriteLine("Yarın : " + bugun.AddDays(1));
            Console.WriteLine("Yarından sonra : " + bugun.AddDays(2));
            Console.WriteLine("Dün : " + bugun.AddDays(-1));
            Console.WriteLine("Evvelsi Gün : " + bugun.AddDays(-2));


            Console.WriteLine("Seneye Bugün : " + bugun.AddYears(1));
            Console.WriteLine("Önümüzdeki Ay : " + bugun.AddMonths(1));


            Console.WriteLine("Beş Saat Sonrası : " + bugun.AddHours(5));
            Console.WriteLine("Beş Dakika Sonrası : " + bugun.AddMinutes(5));
            Console.WriteLine("Beş Saniye Sonrası : " + bugun.AddSeconds(5));
            Console.WriteLine("Beş MiliSaniye Sonrası : " + bugun.AddMilliseconds(5));



            int miliSaniye = bugun.Millisecond;
            int saniye = bugun.Second;
            int dakika = bugun.Minute;
            int saat = bugun.Hour;
            int gun = bugun.Day;
            int ay = bugun.Month;
            int yil = bugun.Year;




            Console.Clear();
            DateTime ayinIlkGunu = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            Console.WriteLine("Ayın Birinci Günü : " + ayinIlkGunu.ToShortDateString());


            DateTime ayinSonGunu = ayinIlkGunu.AddMonths(1).AddDays(-1);
            DateTime ayinSonGunu2 = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(1).AddDays(-1);
            Console.WriteLine("Ayın Son Günü : " + ayinSonGunu.ToShortDateString());



            string ayinAdi = bugun.ToString("MMMM");
            string gununAdi = bugun.ToString("dddd");
            Console.WriteLine("Günün Adı = " + gununAdi);
            Console.WriteLine("Ayın Adı = " + ayinAdi);
        }
    }
}
