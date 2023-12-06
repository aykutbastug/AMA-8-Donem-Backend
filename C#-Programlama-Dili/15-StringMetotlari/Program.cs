namespace _15_StringMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trim() metodu string değerin başındaki ve sonundaki boşluk karakterini kaldırır
            string _adiSoyadi = "  Aykut  Baştuğ        ";
            string adiSoyadi1 = _adiSoyadi.Trim();
            string adiSoyadi2 = _adiSoyadi.TrimEnd(); //sadece sondaki boşlukları siler
            string adiSoyadi3 = _adiSoyadi.TrimStart(); //sadece baştaki boşlukları siler


            //ToLower() tüm harfleri küçük harfe dönüştürür
            string _isim = "AYKUt bAŞTuĞ";
            string isim1 = _isim.ToLower();


            //ToUpper() tüm harfleri büyük harfe dönüştürür
            string isim2 = _isim.ToUpper();


            //Replace() metnin içindeki haerhangi bir değeri farklı bir değer ile değiştirmek için kullanılır
            string _aciklama = "metnin içindeki haerhangi bir değeri farklı bir değer";
            string aciklama1 = _aciklama.Replace('i', 'İ');
            string aciklama2 = _aciklama.Replace(' ', '-');
            string aciklama3 = _aciklama.Replace(" ", "");
            string aciklama4 = _aciklama.Replace("a", "");
            string aciklama5 = _aciklama.Replace("bir", "iki");


            //ToCharArray() metnin içindeki tüm karakterleri char dizisine dönüştürerek geriye döner
            string ilce = "Ümraniye";
            char[] karakterler1 = ilce.ToCharArray();
            char[] karakterler2 = ilce.ToCharArray(3, 2);



            //PadLeft() metnin istediğimiz karakter sayısına ulaşana kadar sol tarafına değer ekliyor.
            string _faturaNo = "41";
            string faturaNo1 = _faturaNo.PadLeft(5, '0');


            //PadRight() metnin istediğimiz karakter sayısına ulaşana kadar sağ tarafına değer ekliyor.
            string faturaNo2 = _faturaNo.PadRight(4, '0');




            //Equals() parametre olarak verilen değer ile değişkenin değeri aynı mı değil mi diye kontrol eder.
            string _metin = "kıyaslamak için kullanılır";

            bool esitMi1 = _metin.Equals("için");
            bool esitMi2 = _metin.Equals("kıyaslamak için kullanılır");

            if (_metin == "kıyaslamak için kullanılır")
                esitMi1 = true;
            else
                esitMi1 = false;




            //SubString() metodu string bir değer içerisinden parça almak için kullanılır
            string _ornek = "Örnek metni buraya giriyorum";
            string ornek1 = _ornek.Substring(5);
            string ornek2 = _ornek.Substring(5, 4);



            //Reverse() metodu metnin içindeki karakterleri bir dizi haline getirerek tersten sıralar
            string _terstenMetin = "Aykut BAŞTUĞ";
            char[] metinDizi = _terstenMetin.Reverse().ToArray();
            string testenMetin = "";
            foreach (var item in metinDizi)
            {
                testenMetin += item.ToString();
            }
            Console.WriteLine(testenMetin);



            //IndexOf() metodu metnin içindeki bir karakterin yada kelimenin kaçıncı indexte olduğunu bize geriye döner.
            string notebook = "Asus Zenbook";
            int index1 = notebook.IndexOf('o');
            int index2 = notebook.IndexOf("Zen");
            int index3 = notebook.IndexOf("zen");


            //Remove() metodu metnin içindeki herhangi bir indexten itibaren karekterleri silmek için kullanılır. metnin içerisinden parça silmek için.
            string _mevsim = "Ağustos";
            string mevsim1 = _mevsim.Remove(3);
            string mevsim2 = _mevsim.Remove(3, 2);
            //string mevsim3 = _mevsim.Remove(3, 5); //eğer olmayan bir index numarası verilirse kod satırı hata verir
            //string mevsim3 = _mevsim.Remove(13, 5); //eğer olmayan bir index numarası verilirse kod satırı hata verir





            //Contains() metodu metnin içinde bir karakteri yada kelimeyi içeriyormu diye kontrol etmek için kullanılır.
            string marka = "philips";
            bool iceriyorMu1 = marka.Contains('i');
            bool iceriyorMu2 = marka.Contains("lip");
            bool iceriyorMu3 = marka.Contains("olip");
            bool iceriyorMu4 = marka.Contains('o');
            bool iceriyorMu5 = marka.Contains('İ');
            bool iceriyorMu6 = marka.Contains("LİP");
            bool iceriyorMu7 = marka.Contains("i");




            //Split() metodu metinin içindeki bir karakterden itibaren tüm metni parçalayarak bir string dizisi haline dönüştürür.
            string gunler = "Pazartesi;Salı;Çarşamba;Perşembe;Cuma;Cumartesi;Pazar";
            string[] gunlerDizisi = gunler.Split(';');
            foreach (var item in gunlerDizisi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine( "-------");

            string gunler2 = "Pazartesi--Salı--Çarşamba--Perşembe--Cuma--Cumartesi--Pazar";
            string[] gunlerDizisi2 = gunler2.Split("--");
            foreach (var item in gunlerDizisi2)
            {
                Console.WriteLine(item);
            }




            //StartsWith() metodu metnin herhangi bir karakter yada kelime ile başlayıp başlamadığını kontrol ediyor.
            string meyve = "Portakal";
            bool ileBasliyorMu1 = meyve.StartsWith('p');
            bool ileBasliyorMu2 = meyve.StartsWith('P');
            bool ileBasliyorMu3 = meyve.StartsWith('x');

            bool ileBasliyorMu4 = meyve.StartsWith("Por");
            bool ileBasliyorMu5 = meyve.StartsWith("por");



            //EndsWith() metodu metnin herhangi bir karakter yada kelime ile bitip bitmediğini kontrol ediyor.
            bool ileBitiyorMu1 = meyve.EndsWith('l');
            bool ileBitiyorMu2 = meyve.EndsWith('L');
            bool ileBitiyorMu3 = meyve.EndsWith('x');

            bool ileBitiyorMu4 = meyve.EndsWith("kal");
            bool ileBitiyorMu5 = meyve.EndsWith("Kal");



            Console.Clear();



            //IsNullOrEmpty() metodu metnin NULL veya boş oluğ olmadığını kontrol eder. Null veya boş ise True değil ise False değeri geriye döndürür.
            //string isim = "";
            string? isim = null;
            isim = "Aykut";

            if (string.IsNullOrEmpty(isim) == true)
                Console.WriteLine("isim girmediniz");
            else
                Console.WriteLine("Merhaba " + isim);




            //kullanıcıdan 3 tane isim istesin isim girmediyse isim girmediniz uyarsını versin tekrar girmesini sağlasın, 3 ismi girdikten sonra M harfi ile başlayanları alt alta ekrana yazdırsın.

        }
    }
}
