namespace _06_TryCatchKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                //hata alınma ihtimali olan kodları bu bloğun içerisine yazabiliriz.
                //ÖNEMLİ NOT: 100 tane satır varsa, 10.satırda hata alındı ise 10.satır ve sonrasındaki hiç bir satır çalıştırılmaz.
			}
			catch (Exception hata)
			{
                //hata alındığında çalışmasını istediğimiz kodları bu bloğa yazabiliriz.
			}
            finally
            { 
                //hata alınsada alınmasada çalışmasını istediğimiz kodları bu bloğa yazabiliriz
                //finally bloğunu yazmak zorunda değiliz, yazdıysak hata alsada almasa da bu bloğa giriyor
            }



            //try
            //{
            //    Console.WriteLine("Birinci sayıyı giriniz..");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("İkinci sayıyı giriniz..");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (Exception hata)
            //{
            //    Console.WriteLine("Hata Alındı");
            //    Console.WriteLine("Message=" + hata.Message);
            //    Console.WriteLine("InnerException=" + hata.InnerException);
            //    Console.WriteLine("StackTrace=" + hata.StackTrace);
            //}

            //herhangi bir hata aldığında devam et yani catch bloğuna geç anlamına gelen kod: catch bloğunu bos bırakıyoruz

            //try
            //{
            //    Console.WriteLine("Birinci sayıyı giriniz..");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("İkinci sayıyı giriniz..");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());
            //}
            //catch {; }


            try
            {
                Console.WriteLine("Birinci sayıyı giriniz..");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("İkinci sayıyı giriniz..");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception hata)
            {
                Console.WriteLine("Hata Alındı");
            }
            finally {
                Console.WriteLine("işlem tamamlandı");
            }

            Console.ReadKey();
        }
    }
}
