namespace _11_DiziKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizinin eleman sayısını belirleterek içi boş olacak şekilde oluşturmak için kullanılır
            int[] rakamlar = new int[5];
            string[] isimler = new string[6];

            //Dizinin bir elemanına değer yazma
            rakamlar[0] = 5;
            rakamlar[3] = 10;

            //Dizinin x indexine sahip elemanının değerini verir
            //isimler[0]

            Console.WriteLine(rakamlar[0]);
            Console.WriteLine(rakamlar[1]);

            isimler[0] = "Aykut";
            isimler[1] = "Savaş";

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[4]);


            //dizinin hem elaman sayısını, hem de elamanlarına değer ataması yaparak dizi oluşturma
            string[] arabalar = new string[3] { "Volvo", "Bmw", "Ford" };
            Console.WriteLine(arabalar[1]);


            //dizinin eleman sayısını belirtmeden, değer ataması yaparak eleman sayısı ve değerlerini oluşturma
            string[] renkler = new string[] { "Kırmızı", "Beyaz" };
            string[] renkler2 = { "Kırmızı", "Beyaz" };
                      

            for (int i = 0; i < arabalar.Length; i++)
            {
                Console.WriteLine(arabalar[i]);
            }
        }
    }
}
