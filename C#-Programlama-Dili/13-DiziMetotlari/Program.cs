using System.Collections;

namespace _13_DiziMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //GetValue() metodu ile dizin içindeki değerini almak istediğimiz index verisi ile elemana erişmek için kullanırız
            string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs" };
            string ay1 = aylar[0];
            string ay2 = aylar.GetValue(1).ToString();
            object ay3 = aylar.GetValue(1);


            int[] intDizisi = { 40, 50, 60, 70 };
            int deger1 = Convert.ToInt32(intDizisi.GetValue(2));
            string deger2 = intDizisi.GetValue(2).ToString();


            //SetValue() elimizdeki bir indexeistinaden, dizinin elemanına değer ataması yapmak için kullanılır.
            aylar.SetValue("Aralık", 4);


            //Array.IndexOf() metodu dizinin içindeki bir elemanın index numarasını almak için kullanırız.
            //ÖNEMLİ NOT : eğer aramak istediğimiz değer, dizinin içerisinde birden fazla ise ilk elemanın index'ini döner
            int indexNo = Array.IndexOf(aylar, "Mart");


            //Dizinin içerisinde kaç tane elaman oldğunu bize döner
            int elamanSayisi = aylar.Length;


            //Array.Sort() metodu ile dizinin içindeki elemanları sırayalabiliriz.
            //eğer elemanlar sayısal bir değere sahipse, küçükten büyüğe doğru sılama yapar
            //eğer string bir değer ise A'dan Z'ye doğru sıralama yapar

            Console.WriteLine("Normal hali");
            foreach (string ay in aylar)
            {
                Console.WriteLine(ay);
            }
            Array.Sort(aylar);
            Console.WriteLine("Sort metodu ile sıralnmış hali");
            foreach (string ay in aylar)
            {
                Console.WriteLine(ay);
            }

            int[] sayilar = { 1, 6, 4, 3, 9, 0 };
            Array.Sort(sayilar);
            foreach (int sayi in sayilar)
                Console.WriteLine(sayi);



            //Array.Reverse() metodu ile dizinin içindeki elemanları tersten sıralayabiliriz. büyükten küçüğe, yada Z'den A'ya
            //Array.Sort(sayilar);
            Array.Reverse(sayilar);

            int[] sayilar2 = { 1, 6, 4, 3, 9, 0 };
            Array.Sort(sayilar2);
            Array.Reverse(sayilar2);



            //Array.Clear() metodu ile dizi içindeki elemanları silebiliriz.
            //ÖNEMLİ NOT: elamn sayısını silmek değil, silme yaptığımızda eleman sayısı aynı şekilde kalır sadece değerleri silinir.

            //Array.Clear(sayilar2);
            //Array.Clear(aylar);
            Array.Clear(sayilar2, 2, 2);


            Console.Clear();
            //Clone() metodu bir dizinin aynısından bir tana daha kopyasını oluşturur
            string[] renkler = { "Kırmızı", "Beyaz", "Yeşil", "Mor" };
            string[] renklerKlon = (string[])renkler.Clone();
            foreach (var renk in renklerKlon)
            {
                Console.WriteLine(renk);
            }



            Console.Clear();
            //Array.Copy()
            string[] renklerYeni = new string[renkler.Length];
            Array.Copy(renkler, 1, renklerYeni, 0, 2);

            foreach (var item in renkler)
            {
                int index = Array.IndexOf(renkler, item);
                Console.WriteLine(index + ". Eleman = " + item);
            }

            Console.WriteLine("-----------");

            foreach (var item in renklerYeni)
            {
                int index = Array.IndexOf(renklerYeni, item);
                Console.WriteLine(index + ". Eleman = " + item);
            }

            Console.WriteLine("-----------Sıralı");
            Array.Sort(renklerYeni);
            foreach (var item in renklerYeni)
            {
                int index = Array.IndexOf(renklerYeni, item);
                Console.WriteLine(index + ". Eleman = " + item);
            }



            Console.Clear();
            //Array.Resize() metodu ile dizinin eleman sayısını değiştirebiliriz.
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba" };
            foreach (var gun in gunler)
            {
                Console.WriteLine(gun);
            }

            Console.WriteLine("--------------");
            Array.Resize(ref gunler, 5);
            gunler[4] = "Cuma";
            foreach (var gun in gunler)
            {
                Console.WriteLine(gun);
            }



            Console.Clear();
            //ArrayList : dinamik olarak büyüyüp küçülebilen, farklı değişken tiplerinde değerleri saklayabilen koleksiyon tabanlı bir sınıftır.
            //diziler ve arrayList sınıfı arasındaki farklar
            //1-Dizilerin boyutunu oluştururken belirtmek zorundayız, ArrayList sınıfında belirtmeden oluşturup istediğimiz ekleme çıkarma yaparak boyutunu değiştirebiliriz.
            //2-Dizilerin tipi baştan belirlenir ve sadece o tipde değerler alır, ArrayList sınıfında istediğimiz tipde değer ataması yapabiliriz.

            
            ArrayList rakamlar = new ArrayList();
            rakamlar.Add(6);
            rakamlar.Add(7);
            rakamlar.Add(8);
            rakamlar.Add(2);
            //arrayList.Add("elma");
            rakamlar[2] = 1;
            //arrayList[1] = "ahmet";
            rakamlar.Sort(); //a'dan Z'ye sıralama yapar, küçükten büyüğe sıralama yapar
            rakamlar.Reverse();//Z'den A'ya sıralama yapar, büyükten küçüğe sıralama yapar NOT: Öncelikle mutlaka Sort() metodu çalıştırılmak zorunda.
            rakamlar.Remove(7); //elamanın değerini kullanarak silme işlemi yapar
            rakamlar.RemoveAt(0); //index numarası ile elamn siler

            Console.WriteLine("Elaman sayısı = " + rakamlar.Count);
            rakamlar.Clear();
            Console.WriteLine("Elaman sayısı = " + rakamlar.Count);


            foreach (var array in rakamlar)
            {
                Console.WriteLine(array);
            }

        }
    }
}
