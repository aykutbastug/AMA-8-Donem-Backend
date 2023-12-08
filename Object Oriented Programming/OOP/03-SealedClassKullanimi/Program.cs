using _03_SealedClassKullanimi.Models;

namespace _03_SealedClassKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cihaz cihaz = new Cihaz();
            cihaz.Barkod = "12312";

            Console.WriteLine("Hello, World!");

           
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Adi = "Aykut";
            //ogrenci.Adi("Aykut");
            //ogrenci.NotOrtalamasi = 12;
            ogrenci.OdevYap();
            

            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Maas = 123;
            ogretmen.Adi = "Aykut";
            ogretmen.DerseHazirlan();
            

            Yonetici yonetici = new Yonetici();
            yonetici.Meslek = "Müdür";
            yonetici.MaasOde();
        }
    }


    //miras alınamaz class'lardır diyebiliriz
    public sealed class Cihaz
    {
        public string Barkod { get; set; }
    }

    public class Elektronik
    {

    }
}



//öğrenci, öğretmen, yönetici

//tümü adı, soyadı, doğumtarihi bu özelliklere sahip
//öğretmen ve yönetici Maaş, Mesleği özelliklerine sahip
//öğretmen DerseHazırlan(), DersAnlat() işlreini yapabilir. (metot)
//yönetici MaaşÖdeme işini yapabilir.
//öğrenci de DersÇalış(), TekrarEt(), ÖdevYap() işlerini yerine getirebilir. ve NotOrtalaması özelliğine sahip olmalı