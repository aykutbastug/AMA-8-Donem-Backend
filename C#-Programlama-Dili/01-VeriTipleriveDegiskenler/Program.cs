
using System.Reflection;

namespace _01_VeriTipleriveDegiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tek satırlık yorum
            /*
             birden çok
             satırı yorum
             olarak eklemek için kullanılır
            */

            //birden çok
            // satırı yorum
            // olarak eklemek için kullanılır


            //1.Süslü parantez {}
            //2.Parantez ()
            //3.Noktalı Virgül ;
            //4.Türkçe karekter yok

            int sayi1 = 999;
            int sayi2 = 999;

            int sayi3, sayi4; //değerleri sıfırdır
            sayi3 = 5;
            sayi3 = 45;

            decimal virgulluSayi1 = 2.5M;
            decimal virgulluSayi2 = 2205;
            //decimal virgulluSayi1 = 2.5m;

            float virgulluSayi3 = 1.53F;
            float virgulluSayi4 = 1;
            //float virgulluSayi2 = 1.53f;

            double virgulluSayi5 = 5.5D;
            //double virgulluSayi3 = 5.5d;
            //double virgulluSayi3 = 5.5;

            //CTRL+Z => yapılan son işlemi geri alır
            //CTRL+Y => geri alınan son işlemi yeniden yazar

            short kucukSayi1 = 23;

            string metin;
            metin = string.Empty;
            metin = "";
            string metin1 = "ada&21356";
            string metin2 = "125";
            string metin3 = "yapılan son işlemi geri alır \\yapılan son işlemi geri alıryapılan son işlemi geri alıryapılan son işlemi geri alıryapılan son işlemi geri alıryapılan son işlemi geri alır";
            string metin4 = "satır1\nsatır2\nsatır3";


            char karakter1 = '0';
            char karakter2 = 'A';
            char karakter3 = 'b';
            char karakter4 = '*';
            char karakter5 = ' ';


            bool evet = true;
            bool hayir = false;

            object degisken1 = "asd";

            int? nullSayi1 = null;
            bool? nullBool1 = null;
            string? nullString = null;

            DateTime dateTime1 = DateTime.Today;
            DateTime dateTime2 = DateTime.Now;
            DateTime? dateTime3 = null;



            Console.WriteLine(metin3);
            metin3 = "aaa";
            Console.WriteLine(metin3);
            //Console.WriteLine("satır");

            //Console.Write("örnek1");
            //Console.Write("örnek2");

            Console.ReadKey();



            //ÖRNEK SORU : 

            //Adı Soyadı
            //TC Kimlik No
            //Telefon
            //Email
            //Yaş (Boş Geçilebilir)
            //Doğum Tarihi (Boş Geçilebilir)
            //Evli Mi ?

            string adiSoyadi = "Aykut BAŞTUĞ";
            ulong tCKimlikNo = 123;
            //string tcKimlikNo = "51653355665";
            string telefonNo = "0 543 375 8551";
            string email = "aykutbastug@gmail.com";
            ushort? yas = 78;
            DateTime? dogumTarihi = DateTime.Today;
            //string dogumTarihi2 = "01.01.2002";
            bool evliMi = false;
            //string evliMi1 = "Evet";
        }

    }
}