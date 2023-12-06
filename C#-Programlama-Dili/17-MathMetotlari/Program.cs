namespace _17_MathMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math.Max() En büyük değeri bulmak için kullanılır
            int enBuyuk = Math.Max(5, 10);
            int enBuyuk2 = Math.Max(18, Math.Max(5, 10));
            Console.WriteLine("Büyük Sayi = " + enBuyuk);
            Console.WriteLine("Büyük Sayi = " + enBuyuk2);



            //Math.Min() En küçük değeri bulmak için kullanılır
            int enKucuk = Math.Min(5, 10);
            int enKucuk2 = Math.Min(18, Math.Min(5, 10));
            Console.WriteLine("Küçük Sayi = " + enKucuk);
            Console.WriteLine("Küçük Sayi = " + enKucuk2);


            //Math.Sqrt(x) parametre oalrak verilen x sayısının karekökünü hesaplayarak geriye döner
            double kareKok = Math.Sqrt(64);
            Console.WriteLine("64'ün kare kökü = " + kareKok);



            //Math.Abs(x) parametre olarak verilen x değerinin mutlak (pozitif) karşılığını gerite dönüyor
            int mutlakDeger = Math.Abs(-14);
            double mutlakDeger2 = Math.Abs(-14.5);
            Console.WriteLine("-14 ün mutlak değeri = " + mutlakDeger);
            Console.WriteLine("-14.5 in mutlak değeri = " + mutlakDeger2);



            //Math.Round(x) kendisine en yakın TAM SAYIYA yuvarlar
            double yuvarla1 = Math.Round(7.99);
            double yuvarla2 = Math.Round(7.49);


            double yuvarla3 = Math.Round(4.5123, 2);
            double yuvarla4 = Math.Round(4.5123, 1);
            double yuvarla5 = Math.Round(4.1245, 0);




            //Math.Floor(x) paremetre olarak verilen sayıyı bir alt TAM SAYIYA yuvarlar
            double asagiYuvarla = Math.Floor(7.99);


            //Math.Ceiling(x) paremetre olarak verilen sayıyı bir üst TAM SAYIYA yuvarlar
            double yukariYuvarla = Math.Ceiling(7.12);


            double piSayisi = Math.PI;
            Console.WriteLine("Pi Sayısı = " + piSayisi);


        }
    }
}
