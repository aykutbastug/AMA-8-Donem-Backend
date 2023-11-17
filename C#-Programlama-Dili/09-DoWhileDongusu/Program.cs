namespace _09_DoWhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do
            //{
            //    //çalıştırılması gereken kodlar bu bloğa yazırlı

            //    //arttırma işlemi manüel yapılır
            //}
            //while (true);

            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;

            //} while (i < 1);


            //i = 1;
            //while (i < 1)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            int sayi = 0;
            do
            {
                Console.WriteLine("Pozitif bir sayı girin..");
                try
                {
                    sayi = Convert.ToInt32(Console.ReadLine());
                }
                catch {; }
                //

            } while (sayi <= 0);

            //
        }
    }
}
